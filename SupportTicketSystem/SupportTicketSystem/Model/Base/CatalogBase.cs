﻿using System;
using System.Collections.Generic;
using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem.Model.Base
{
    public abstract class CatalogBase<T> : ICatalog<T>
        where T : IDomainClass
    {
        public event Action<int> CatalogChanged;

        public abstract List<T> All { get; }
        public abstract T Read(int id);
        protected abstract void Insert(T obj);
        protected abstract void Remove(int id);

        public void Create(T obj)
        {
            Insert(obj);
            OnCatalogChanged(obj.GetId());
        }

        public void Delete(int id)
        {
            Remove(id);
            OnCatalogChanged(id);
        }

        protected virtual void OnCatalogChanged(int id)
        {
            CatalogChanged?.Invoke(id);
        }
    }
}