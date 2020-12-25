using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.Entity;
using Ninject;

namespace Presenter
{
    public class edit_timetablePresenter
    {
        private readonly IKernel _kernel;
        private Iedit_timetable _view;
        private IRepository<Timetable> _timetablerepository;
        private ITimetableService _timetableservice;

        private string current_timetable_id;
        private string current_user;

        public edit_timetablePresenter(IKernel kernel, Iedit_timetable view, IRepository<Timetable> timetablerepository, ITimetableService timetableservice)
        {
            _kernel = kernel;
            _view = view;
            _timetablerepository = timetablerepository;
            _timetableservice = timetableservice;

            //_view.Remove_timestamp += Remove_timestamp;
            _view.Show_goback += Show_goback;
            _view.Show_save_goback += Show_save_goback;
        }

        private void Show_save_goback(List<Time> timestamps, string name)
        {
            short save_timetable_response = _timetableservice.Save_Timetable(current_timetable_id, timestamps, name);
            //сохранить!!!
            _view.display_save_timetable_response(save_timetable_response);
            if (save_timetable_response != 0) return;
            var presenter = _kernel.Get<manage_timetablesPresenter>();
            presenter.Run(current_user);
            _view.Close();
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<manage_timetablesPresenter>();
            presenter.Run(current_user);
            _view.Close();
        }

        public void Run(string username, string timetable_id)
        {
            current_user = username;
            current_timetable_id = timetable_id;
            _view.Show();
            Timetable timetable = _timetablerepository.Get(timetable_id);
            List<Time> timestamps = timetable.TimeOfFeed;
            string name = timetable.name;
            _view.load_timetable_name(name);
            _view.display_timestamp_list(timestamps);
        }
    }
}
