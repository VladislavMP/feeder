﻿using Model;
using Model.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    class feeder_id_listPresenter
    {
        private readonly IKernel _kernel;
        private Ifeeder_id_list _view;
        private IRepository<Feeder> _feederrepository;

        private string current_admin;
        private List<Feeder> GLOBAL_feederlist;

        public feeder_id_listPresenter(IKernel kernel, Ifeeder_id_list view, IRepository<Feeder> feederrepository)
        {
            _kernel = kernel;
            _view = view;
            _feederrepository = feederrepository;

            _view.Add_feeder += Add_feeder;
            _view.Remove_feeder += Delete_feeder;
            _view.Show_goback += Show_goback;
            _view.Show_feeder_info += Show_feeder_info;
        }

        private void Show_feeder_info(string feeder_id)
        {
            var presenter = _kernel.Get<feeder_infoPresenter>();
            presenter.Run(current_admin, feeder_id);
            _view.Close();
        }

        private void Show_goback()
        {
            var presenter = _kernel.Get<home_adminPresenter>();
            presenter.Run(current_admin);
            _view.Close();
        }

        private void Delete_feeder(string feeder_id)
        {
            if (_feederrepository.Get(feeder_id) != null)
            {
                _feederrepository.Remove(_feederrepository.Get(feeder_id));
                GLOBAL_feederlist = _feederrepository.GetAll();
                _view.display_GLOBAL_feeder_list(GLOBAL_feederlist);
                _view.UpdateSim();
            }
        }

        private void Add_feeder(string feeder_id)
        {
            if (feeder_id == "") return;

            Feeder feeder0 = _feederrepository.Get(feeder_id);

            if (feeder0 != null) return;

            Feeder feeder = new Feeder(feeder_id, "Кормушка uWu");
            _feederrepository.Add(feeder);
            GLOBAL_feederlist = _feederrepository.GetAll();
            _view.display_GLOBAL_feeder_list(GLOBAL_feederlist);
        }

        public void Run(string username)
        {
            current_admin = username;
            _view.Show();
            GLOBAL_feederlist = _feederrepository.GetAll();
            _view.display_GLOBAL_feeder_list(GLOBAL_feederlist);
        }
    }
}
