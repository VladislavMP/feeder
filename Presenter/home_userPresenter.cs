using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class home_userPresenter
    {
        private readonly IKernel _kernel;
        private Ihome_user _view;
        public home_userPresenter(IKernel kernel, Ihome_user view)
        {
            _kernel = kernel;
            _view = view;

            _view.Show_add_feeder += Show_add_feeder;
            _view.Show_manage_timetables += Show_manage_timetables;
            _view.Show_logout += Show_logout;
        }

        private void Show_manage_timetables()
        {
            var presenter = _kernel.Get<manage_timetablesPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_logout()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_add_feeder()
        {
            var presenter = _kernel.Get<add_feederPresenter>();
            presenter.Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}