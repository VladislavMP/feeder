﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Ihome_user : Iview
    {
        public event Action Show_add_feeder;
        public event Action Show_manage_timetables;
        public event Action Show_logout;
    }
}
