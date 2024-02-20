using System;
using System.Collections.Generic;
using System.Text;


namespace Shared_epreuve.Repositories
{
    public interface IProduitRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        IEnumerable<TEntity> GetByCategorie(string Categorie);
        IEnumerable<TEntity> GetByEcoscore (string Ecoscore);

        IEnumerable<TEntity> GetByName(string Nom);

        IEnumerable<TEntity> GetByFavoris(int id);
    }
}
