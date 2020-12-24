using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class edit_feederPresenter
    {
        private readonly IKernel _kernel;
        private Iedit_feeder _view;
        private IRepository<Feeder> _feederrepository;
        private IRepository<Timetable> _timetablerepository;

        private string current_user_id;
        private string current_feeder_id;

        public edit_feederPresenter(IKernel kernel, Iedit_feeder view, IRepository<Feeder> feederrepository, IRepository<Timetable> timetablerepository)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;
            _timetablerepository = timetablerepository;

            _view.Show_goback += Show_goback;
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_userPresenter>();
            presenter.Run(current_user_id);
            _view.Close();
        }

        public void Run(string username, string feeder_id)
        {
            current_user_id = username;
            current_feeder_id = feeder_id;
            _view.Show();
        }
    }
}
