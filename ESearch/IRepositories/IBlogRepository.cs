using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IBlogRepository
    {
        bool establishConnection(string connectionstring);

        bool createBlog(string blogName);

        bool addArticles(IEnumerable<Article> lstArticles);

        IEnumerable<Article> searchBlog(string articleId);
    }
}
