using System;
using System.Collections.Generic;
using SupportTicketSystem.Data.Base;

namespace SupportTicketSystem.Model.Base
{
    public abstract class CatalogBase<T> : ICatalog<T>
        where T : IDomainClass
    {
        public event Action<int> CatalogChanged;

        // Disse fire metoder kan vi ikke implementere generelt, derfor må
        // vi erklære dem abstract, og implementere dem i nedarvede klasser
        // 
        public abstract List<T> All { get; }
        public abstract T Read(int id);
        protected abstract void Insert(T obj);
        protected abstract void Remove(int id);

        // Den generelle algoritme for Create. Dette er et (meget lille)
        // eksempel på en Template Method.
        public void Create(T obj)
        {
            Insert(obj);
            OnCatalogChanged(obj.GetId());
        }

        // Den generelle algoritme for Delete. Dette er et (meget lille)
        // eksempel på en Template Method.
        public void Delete(int id)
        {
            Remove(id);
            OnCatalogChanged(id);
        }

        // Hjælpe-metode til at aktivere eventet CatalogChanged.
        // Kaldes fra Create og Delete.
        protected virtual void OnCatalogChanged(int id)
        {
            CatalogChanged?.Invoke(id);
        }
    }
}