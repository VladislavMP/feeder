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

        public add_feederPresenter(IKernel kernel, Iadd_feeder view)
        {
            _kernel = kernel;
            _view = view;

            _view.Show_goback += Show_goback;
        }

        private void Show_goback()
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
