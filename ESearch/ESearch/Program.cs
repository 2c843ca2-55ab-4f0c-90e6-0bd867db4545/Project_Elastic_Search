using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels;
using IRepositories;
using System.Configuration;

namespace ESearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = ConfigurationSettings.AppSettings["elasticSearchUri"];
            IBlogRepository objBlog = RepositoryFactory.GetRepository();
            objBlog.establishConnection(url);

           // var elastic = new ElasticClient(settings);

           // var res = elastic.CreateIndex("blog1", null);
           // if (res.Acknowledged)
           //     elastic.Map<Client>(c => c.AutoMap());

           // var documents = new List<Client>() { new Client(){Id=1,Name="Manjesh",Surname="Anjanappa",Email="manjesh@dell.com"},
           //new Client(){Id=2,Name="Ramesh",Surname="VP", Email="Ramesh@dell.com"}};
           // documents.ForEach((document) =>
           // {
           //     elastic.Index<Client>(document, idx => idx.Index("blog"));
           // });
           // var search = elastic.Search<Client>(c => c.AllIndices().Query(b => b.Term(v =>v.Field(g=>g.Id).Value(2))));
            Console.ReadLine();
        }
    }
}
