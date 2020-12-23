using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRepository<T> where T : class
    {
        int Add(T obj);
        void Remove(T obj);
        void Save();

        T Get(string id);

    }
}

