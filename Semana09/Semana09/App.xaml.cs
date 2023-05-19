﻿using System;
using Semana09.Services;
using Semana09.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana09
{
    public partial class App : Application
    {

        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SwipeDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
