using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Imanage_timetables : Iview
    {
        public event Action Show_goback;
    }
}
