using Shared_epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using DAL = DAL_Epreuve.Services;

namespace BLL_Epreuve.Services
{
    public class CategorieService : ICategorieRepository<string>
    {
        private readonly DAL.CategorieService _repoCategorie;
        public CategorieService(DAL.CategorieService repoCategorie) 
        {
            _repoCategorie = repoCategorie;
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
