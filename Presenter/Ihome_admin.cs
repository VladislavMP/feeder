using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Ihome_admin : Iview
    {
        public event Action Show_logout;
        public event Action Show_feeder_id_list;
        public event Action<string> Remove_user;
        public event Action Show_global_stats;

        void Display_user_list(List<User> userlist);
    }
}
