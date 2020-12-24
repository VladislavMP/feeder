using Model.Entity;
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

        List<T> GetList(string id);
        List<T> GetAll(string id);
        T Get(string id);
    }
}

