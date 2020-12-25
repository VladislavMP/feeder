using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iedit_timetable : Iview
    {
        public event Action Show_goback;
        public event Action<List<Time>, string> Show_save_goback;

        void display_timestamp_list(List<Time> timestamps);
        void load_timetable_name(string name);
        void display_save_timetable_response(short save_timetable_response);
    }
}
