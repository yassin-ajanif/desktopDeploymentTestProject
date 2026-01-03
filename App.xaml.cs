using System;
using System.Windows;
using Velopack;

namespace HelloWPF
{
    public partial class App : Application
    {
        [STAThread]
        private static void Main(string[] args)
        {
            VelopackApp.Build().Run();
            App app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}