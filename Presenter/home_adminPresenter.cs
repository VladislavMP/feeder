using Model;
using Model.Entity;
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
        private IRepository<User> _userrepository;
        private IFeederService _feederservice;
        private string current_admin;

        public home_adminPresenter(IKernel kernel, Ihome_admin view, IRepository<User> userrepository, IFeederService feederservice)
        {
            _kernel = kernel;
            _view = view;
            _userrepository = userrepository;
            _feederservice = feederservice;

            _view.Show_logout += Show_logout;
            _view.Show_feeder_id_list += Show_feeder_id_list;
            _view.Remove_user += Remove_user;
            _view.Show_global_stats += Show_global_stats;
        }

        private void Show_global_stats()
        {
            var presenter = _kernel.Get<statsPresenter>();
            presenter.Run(current_admin);
            _view.Close();
        }

        private void Remove_user(string user_id)
        {
            _userrepository.Remove(_userrepository.Get(user_id));
            _feederservice.Free_feeders_from_deleted_user(user_id);

            List<User> userlist = _userrepository.GetAll();
            if (userlist == null) return;
            _view.Display_user_list(userlist);
        }

        private void Show_feeder_id_list()
        {
            var presenter = _kernel.Get<feeder_id_listPresenter>();
            presenter.Run(current_admin);
            _view.Close();
        }

        private void Show_logout()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }
        public void Run(string username)
        {
            current_admin = username;
            _view.Show();
            List<User> userlist = _userrepository.GetAll();
            if (userlist == null) return;
            _view.Display_user_list(userlist);
        }
    }
}
