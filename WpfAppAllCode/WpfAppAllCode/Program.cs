using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppAllCode
{
    class Program:Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            Program app=new Program();
            app.Startup += (sender, e) =>
            {
                //Window mainWindow=new Window();
                //mainWindow.Title = "我的第一个WPC应用";
                //mainWindow.Height = 200;
                //mainWindow.Width = 300;
                //mainWindow.WindowStartupLocation=WindowStartupLocation.CenterScreen;
                //mainWindow.Show();
                Application.Current.Properties["GodMode"] = false;
                foreach (string arg in e.Args)
                {
                    if (arg.ToLower() == "/godmode")
                    {
                        Current.Properties["GodMode"] = true;
                        break;
                    }
                }
                MainWindow wnd=new MainWindow("我的第一个WPC应用", 200,300);
                wnd.Show();
            };

            app.Exit += (sender, e) =>
            {
                MessageBox.Show("应用以退出");
            };
            app.Run();
        }
    }
}
