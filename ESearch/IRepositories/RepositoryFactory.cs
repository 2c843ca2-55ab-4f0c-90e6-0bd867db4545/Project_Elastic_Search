using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;
using System.Reflection;
using DomainModels;

namespace IRepositories
{
    public static class RepositoryFactory
    {
        public static IBlogRepository GetRepository()
        {
            string type = ConfigurationSettings.AppSettings["elasticSearchRepository"];
            var instance = Activator.CreateInstance("ElasticSearchRepository",type);
            return (IBlogRepository)instance.Unwrap();
        }

       
    }
}
