using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Ifeeder_info : Iview
    {
        public event Action Show_goback;

        void Display_info(string name1, string feeder_id, string name2);
    }
}