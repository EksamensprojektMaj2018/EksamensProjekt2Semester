using System;
using System.Collections.Generic;

namespace SupportTicketSystem.Model.Base
{
        public interface ICatalog<T>
        {
            List<T> All { get; }
            void Create(T obj);
            T Read(int id);
            void Delete(int id);
            event Action<int> CatalogChanged;
        }
}