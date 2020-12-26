using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Istats : Iview
    {
        public event Action Show_goback;

        void DisplayStats(int v);
    }
}
