using Model;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class add_feederPresenter
    {
        private readonly IKernel _kernel;
        private Iadd_feeder _view;
        private IFeederService _feederservice;

        public add_feederPresenter(IKernel kernel, Iadd_feeder view, IFeederService feederservice)
        {
            _kernel = kernel;
            _view = view;
            _feederservice = feederservice;

            _view.Show_goback += Show_goback;
            _view.Add_feeder += Add_feeder;
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Add_feeder(string id)
        {
            _feederservice.Add_feeder(id);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
