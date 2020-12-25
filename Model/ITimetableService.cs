using Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface ITimetableService
    {
        void Add_Timetable(string current_user_id);
        short Save_Timetable(string timetable_id, List<Time> timestamps, string name);
    }
}
