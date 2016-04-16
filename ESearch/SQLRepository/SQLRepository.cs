using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels;
using IRepositories;

namespace Repositories.SQLRepository
{
    public class SQLBlogRepository : IBlogRepository
    {
        public bool establishConnection(string connectionstring)
        {
            throw new NotImplementedException();
        }

        public bool createBlog(string blogName)
        {
            throw new NotImplementedException();
        }

        public bool addArticles(IEnumerable<DomainModels.Article> lstArticles)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DomainModels.Article> searchBlog(string articleId)
        {
            throw new NotImplementedException();
        }
    }
}
