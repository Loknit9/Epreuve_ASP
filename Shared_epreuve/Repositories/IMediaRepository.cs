﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_epreuve.Repositories
{
    public interface IMediaRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
    }
}
