﻿namespace MauiApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage = new NavigationPage(new MainPage());
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            //MainPage = navPage;
            //new AppShell();
            MainPage = new FlyoutPageDemo();
        }
    }
}
