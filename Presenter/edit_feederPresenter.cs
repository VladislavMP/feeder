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
            _view.Save += Save;
        }

        private void Save(string name, string timetable_id)
        {
            short save_result = 0;
            if (name == "") save_result = 1;
            _view.Display_save_result(save_result);
            if (save_result == 1) return;
            Feeder feeder = _feederrepository.Get(current_feeder_id);
            feeder.Name = name;
            feeder.Timetable_id = timetable_id;
            string cond = "feeder_id = '" + current_feeder_id + "'";
            _feederrepository.Update(feeder, cond);
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
            _view.Load_existing_data(_timetablerepository.GetList(username), _feederrepository.Get(feeder_id).Name, _feederrepository.Get(feeder_id).Timetable_id);
        }
    }
}
