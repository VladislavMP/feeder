using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;


namespace Presenter
{
    public class home_userPresenter
    {
        private readonly IKernel _kernel;
        private Ihome_user _view;
        private IRepository<Feeder> _feederrepository;
        public List<Feeder> feederlist;

        public home_userPresenter(IKernel kernel, Ihome_user view, IRepository<Feeder> feederrepository)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;

            _view.Show_add_feeder += Show_add_feeder;
            _view.Show_manage_timetables += Show_manage_timetables;
            _view.Show_logout += Show_logout;
        }

        private void Show_manage_timetables()
        {
            var presenter = _kernel.Get<manage_timetablesPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_logout()
        {
            var presenter = _kernel.Get<loginPresenter>();
            presenter.Run();
            _view.Close();
        }

        private void Show_add_feeder()
        {
            var presenter = _kernel.Get<add_feederPresenter>();
            presenter.Run();
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
            string id = "shitshit";
            feederlist = _feederrepository.GetAll(id); //по id ползователя получаем список кормушек
            _view.display_feeder_list(feederlist);
        }
    }
}