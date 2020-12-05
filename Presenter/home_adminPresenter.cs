using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class home_adminPresenter
    {
        private readonly IKernel _kernel;
        private Ihome_admin _view;
        public home_adminPresenter(IKernel kernel, Ihome_admin view)
        {
            _kernel = kernel;
            _view = view;

            _view.Show_logout += Show_logout;
        }

        private void Show_logout()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
