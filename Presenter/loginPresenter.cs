using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class loginPresenter
    {
        private Ilogin _view;
        var view_instance = 
        var instance = new home_userPresenter();
        public loginPresenter(Ilogin view)
        {
            _view = view;

            _view.Show_home_user += Show_home_user;
        }

        private void Show_home_user()
        {
            instance.Run();
        }
    }
}
