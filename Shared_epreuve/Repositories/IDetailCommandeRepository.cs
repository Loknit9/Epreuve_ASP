using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_epreuve.Repositories
{
    public interface IDetailCommandeRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
