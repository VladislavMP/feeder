using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iedit_feeder : Iview
    {
        public event Action Show_goback;
        public event Action<string, string> Save;

        void Load_existing_data(List<Timetable> lists, string name, string timetable_id);
        void Display_save_result(short save_result);
        void UdpateSim();
    }
}
