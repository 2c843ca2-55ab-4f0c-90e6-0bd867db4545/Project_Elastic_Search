using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepositories;
using DomainModels;
using Nest;

namespace Repositories.ElasticSearchRepository
{
    public class ElasticSearchBlogRepository : IBlogRepository
    {
        private ElasticClient _client = null;
        private string _blogName=string.Empty;

        public bool establishConnection(string connectionstring)
        {
            var local = new Uri(connectionstring);
            var settings = new ConnectionSettings(local);
            _client = new ElasticClient(settings);
            return true;
        }

        public bool createBlog(string blogName)
        {
            _blogName = blogName;
            var res = _client.CreateIndex(_blogName, null);
            if (res.Acknowledged)
                _client.Map<Article>(c => c.AutoMap());
            return res.Acknowledged;
        }

        public bool addArticles(IEnumerable<Article> lstArticles)
        {
            var documents = new List<Article>() { new Article(){Id=1,Name="Manjesh",Surname="Anjanappa",Email="manjesh@dell.com"},
            new Article(){Id=2,Name="Ramesh",Surname="VP", Email="Ramesh@dell.com"}};
            documents.ForEach((document) =>
            {
                _client.Index<Article>(document, idx => idx.Index(_blogName));
            });
            return true;
        }

        public IEnumerable<Article> searchBlog(string articleId)
        {
            var search = _client.Search<Article>(c => c.AllIndices().Query(b => b.Term(v => v.Field(g => g.Id).Value(2))));
            return search.Documents;
        }
    }
}
