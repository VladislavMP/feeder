using System;
using System.Collections.Generic;
using System.Text;
using Ninject;

namespace Presenter
{
    public class manage_timetablesPresenter
    {
        private readonly IKernel _kernel;
        private Imanage_timetables _view;

        public manage_timetablesPresenter(IKernel kernel, Imanage_timetables view)
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
