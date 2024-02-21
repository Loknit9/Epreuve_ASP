using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Services
{
    public class CategorieService : BaseService, CategorieRepository<String>
    {
        public CategorieService(IConfiguration configuration, string dbname) : base(configuration, dbname)
        {
        }

        public IEnumerable<String> Get()
        {

        }
    }
}

