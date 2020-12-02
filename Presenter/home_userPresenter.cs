using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
public class home_userPresenter
{
    private Ihome_user _view;
    public home_userPresenter(Ihome_user view)
    {
        _view = view;
    }

    public void Run()
    {
        _view.Show();
    }
}
}