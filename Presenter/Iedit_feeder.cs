using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public interface Iedit_feeder : Iview
    {
        public event Action Show_goback;
    }
}
