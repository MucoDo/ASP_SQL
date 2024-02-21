﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public interface IProduitRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
      
    }
}