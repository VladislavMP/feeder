using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IRepository<T> where T : class
    {
        string Add(T obj);
        void Remove(string id);
        void Save();

        List<T> GetAll(string id);
        T Get(string id);
    }
}

