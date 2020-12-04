using System;
using System.Collections.Generic;
using System.Text;
using Ninject;

namespace Presenter
{
    public class edit_timetablePresenter
    {
        private readonly IKernel _kernel;
        private Iedit_timetable _view;
        public edit_timetablePresenter(IKernel kernel, Iedit_timetable view)
        {
            _kernel = kernel;
            _view = view;
        }

        public void Run()
        {
            _view.Show();
        }
    }
}
