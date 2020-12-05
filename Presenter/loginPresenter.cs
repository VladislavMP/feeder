using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Model;
using Ninject;

namespace Presenter
{
    public class loginPresenter
    {
        private readonly IKernel _kernel;
        private Ilogin _view;
        private IAuthService _authservice;


        public loginPresenter(IKernel kernel, Ilogin view, IAuthService authservice)
        {
            _kernel = kernel;
            _view = view;
            _authservice = authservice;

            _view.Show_login += Show_login;
        }

        private void Show_login(string username, string password)
        {
            short user_type = _authservice.Login(username, password);
            if (user_type == 1)
            {
                var presenter = _kernel.Get<home_userPresenter>();
                presenter.Run();
                _view.Close();
            }
            else if (user_type == 2)
            {
                var presenter = _kernel.Get<home_adminPresenter>();
                presenter.Run();
                _view.Close();
            }
            else
            MessageBox.Show("не пущу", "Notification", MessageBoxButtons.OK);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
