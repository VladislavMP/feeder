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

        private string current_user_id;

        public manage_timetablesPresenter(IKernel kernel, Imanage_timetables view)
        {
            _kernel = kernel;
            _view = view;

            _view.Show_goback += Show_goback;
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        public void Run(string username)
        {
            current_user_id = username;
            _view.Show();
        }
    }
}
