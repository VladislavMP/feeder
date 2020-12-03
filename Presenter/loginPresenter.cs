using System;
using System.Collections.Generic;
using System.Text;
using Ninject;

namespace Presenter
{
    public class loginPresenter
    {
        private readonly IKernel _kernel;
        private Ilogin _view;
        
        public loginPresenter(IKernel kernel, Ilogin view)
        {
            _kernel = kernel;
            _view = view;

            _view.Show_home_user += Show_home_user;
        }

        private void Show_home_user()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
