﻿using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Model.Service
{
    public class FeederService : IFeederService
    {
        private IRepository<Feeder> _feederrepository;
        private IRepository<User> _userrepository;
        public FeederService(IRepository<Feeder> feederrepository, IRepository<User> userrepository) //check for repository injection
        {
            _feederrepository = feederrepository;
            _userrepository = userrepository;
        }

        public short Activate_feeder(string user_id, string feeder_id)
        {

            Feeder feeder = _feederrepository.Get(feeder_id);
            if (feeder == null) return 0;
            if (feeder.User_id != "") return 0;
            else
            {
                feeder.User_id = user_id;
                string cond = "feeder_id = '" + feeder_id + "'";
                _feederrepository.Update(feeder, cond);
                return 1;
            }
        }

        public void Free_feeders_from_deleted_user(string user_id)
        {
            List<Feeder> feederlist = _feederrepository.GetList(user_id);
            int i, size = feederlist.Count;

            string cond;

            for (i = 0; i < size; i++)
            {
                cond = "feeder_id = '" + feederlist[i].Feeder_id + "'";
                feederlist[i].User_id = "";
                _feederrepository.Update(feederlist[i], cond);

            }
        }
    }
}
