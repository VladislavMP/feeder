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

        public List<Feeder> GetAll(string id)
        {
            List<Feeder> feederlist = new List<Feeder>();
            feederlist.Add(new Feeder());
            return feederlist;
        }

        public Feeder Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
