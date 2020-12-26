using Model.Service;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class statsPresenter
    {
        private readonly IKernel _kernel;
        private Istats _view;

        private StatisticsService _statsservice;

        private string current_admin;

        public statsPresenter(IKernel kernel, Istats view, StatisticsService statsservice)
        {
            _kernel = kernel;
            _view = view;
            _statsservice = statsservice;

            _view.Show_goback += Show_goback;
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_adminPresenter>();
            presenter.Run(current_admin);
            _view.Close();
        }

        public void Run(string username)
        {
            current_admin = username;
            _view.Show();
            _view.DisplayStats(_statsservice.GetStats());
        }
    }
}
