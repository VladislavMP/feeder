using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRepository<T> where T : class
    {
        int Add(T obj);
        void Remove(int id);
        void Save();

    }
}

