using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace FBGEMSystem
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
           
           //  base.OnStartup(e);
            RealtimeStatus.CHBar ch = new RealtimeStatus.CHBar();
            ch.Show();
            // LoginWindow logwindow = new LoginWindow();
            //logwindow.ShowDialog();
        }
    }
}
