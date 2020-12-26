using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class feeder_infoPresenter
    {
        private readonly IKernel _kernel;
        private Ifeeder_info _view;
        private IRepository<Feeder> _feederrepository;
        private IRepository<User> _userrepository;
        private IRepository<Timetable> _timetablerepository;

        private string current_user_id;
        private string current_feeder_id;

        public feeder_infoPresenter(IKernel kernel, Ifeeder_info view, IRepository<Feeder> feederrepository, IRepository<User> userrepository, IRepository<Timetable> timetablerepository)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;
            _userrepository = userrepository;
            _timetablerepository = timetablerepository;

            _view.Show_goback += Show_goback;
        }

        private void Show_goback()
        {
            User user = _userrepository.Get(current_user_id);
            short user_type = user.account_type;
            if (user_type == 2)
            {
                var presenter = _kernel.Get<feeder_id_listPresenter>();
                presenter.Run(current_user_id);
                _view.Close();
            }
            else
            {
                var presenter = _kernel.Get<home_userPresenter>();
                presenter.Run(current_user_id);
                _view.Close();
            }
        }

        public void Run(string username, string feeder_id)
        {
            current_user_id = username;
            current_feeder_id = feeder_id;
            _view.Show();
            Feeder feeder = _feederrepository.Get(feeder_id);
            Timetable timetable = _timetablerepository.Get(feeder.Timetable_id);
            string timetable_name;
            if (timetable == null) timetable_name = "-//-";
            else
            timetable_name = timetable.name;
            
            _view.Display_info(feeder.Name, feeder.Feeder_id, timetable_name);
        }
    }
}
