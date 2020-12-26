using System;
using System.Collections.Generic;
using System.Text;
using Model.Entity;
using Model.Repository;
using System.Threading;
using System.Windows.Forms;

namespace Sim
{
    public static class TestSim
    {
        private static List<Feeder> feeders;
        private static List<Timetable> timetables;
        private static FeederRepository F = new FeederRepository();
        private static TimetableRepository T = new TimetableRepository();
        public static void Refresh()
        {
            timetables = T.GetAll();
            feeders = F.GetAll();
        }
        public static void Sim()
        {
            while (true)
            {
                Thread.Sleep(10000);
                if (timetables != null)
                    foreach (Timetable table in timetables)
                    {
                        foreach (Time t in table.TimeOfFeed)
                        {
                            Time ct = new Time();
                            if (t.TimeHMS == ct.TimeHMS)
                            {
                                string feeder_name = "null";
                                string feeder_id = "null";
                                foreach (Feeder f in feeders)
                                {
                                    if (f.Timetable_id == table.TimetableId)
                                    {
                                        feeder_name = f.Name;
                                        feeder_id = f.Feeder_id;
                                    }
                                }
                                if (feeder_id != "null")
                                MessageBox.Show("Кормушка " + feeder_name + " Id " + feeder_id + " покормила в " + t.TimeHMS);
                            }
                        }
                    }
            }
        }
    }
}
