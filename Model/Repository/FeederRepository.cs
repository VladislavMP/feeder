using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Repository
{
    public class FeederRepository : IRepository<Feeder>
    {
        public string Add(Feeder obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public List<Feeder> GetAll(string id) //id это имя пользователя
        {
            List<Feeder> feederlist = new List<Feeder>();
            feederlist.Add(new Feeder("f7js8kf8", "Кормушечка №1"));
            feederlist.Add(new Feeder("j7sa03j4", "Кормушечка №2"));
            feederlist.Add(new Feeder("092mr90d", "Третья кормушка"));
            feederlist.Add(new Feeder("89hx2esh", "Опа четвёртая"));
            return feederlist;
        }

        public Feeder Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
