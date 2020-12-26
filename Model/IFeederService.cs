using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IFeederService
    {
        short Activate_feeder(string user_id, string feeder_id);
        void Free_feeders_from_deleted_user(string user_id);
    }

}
