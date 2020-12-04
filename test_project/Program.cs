using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Presenter;

namespace test_project
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<Ihome_user>().To<home_user>();
            kernel.Bind<Ilogin>().To<Form1>();
            kernel.Bind<Iadd_feeder>().To<add_feeder>();
            kernel.Bind<Imanage_timetables>().To<manage_timetables>();
            kernel.Bind<Iedit_timetable>().To<edit_timetable>();

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<loginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}