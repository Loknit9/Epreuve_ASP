using DAL_Epreuve.Entities;
using Microsoft.Extensions.Configuration;
using Shared_epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Epreuve.Services
{
    public class CategorieService : BaseService, ICategorieRepository<string>
    {
        public CategorieService(IConfiguration configuration) : base(configuration, "DB_Epreuve_ASP")
        {
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        public string Get(int id)
        {
            throw new NotImplementedException();
        }


        public int Insert(string entity)
        {
            throw new NotImplementedException();
        }

        public void Update(string entity)
        {
            throw new NotImplementedException();
        }
    }
}
