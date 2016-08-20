using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllCode
{
    class MainWindow:Window
    {
        private Button _btnExitApp=new Button();
        public MainWindow(string windowTitle,int height,int width)
        {
            // 配置按钮并设置子控件
            _btnExitApp.Click += (sender, e) =>
            {
                if ((bool) Application.Current.Properties["GodMode"])
                {
                    MessageBox.Show("骗子");
                }
                // 关闭窗体
                Close();
            };
            _btnExitApp.Content = "退出应用";
            _btnExitApp.Height = 25;
            _btnExitApp.Width = 100;

            // 将窗体的内容设置为一个按钮
            Content = _btnExitApp;

            // 配置窗体
            Title = windowTitle;
            Height = height;
            Width = width;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Closing += (sender, e) =>
            {
                string msg = "你想要在不保存的情况下关闭窗体吗？";
                MessageBoxResult result = MessageBox.Show(msg, "我的应用", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            };
            Closed += (sender, e) =>
            {
                MessageBox.Show("再见！");
            };

            // 拦截鼠标事件
            MouseMove += (sender, e) =>
            {
                Title = e.GetPosition(this).ToString();
            };
            KeyDown += (sender, e) =>
            {
                _btnExitApp.Content=e.Key.ToString();
            };

        }
    }
}
