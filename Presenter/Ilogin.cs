using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    

    public interface Ilogin : Iview
    {

        event Action<string> Show_home_user;


    }
}
