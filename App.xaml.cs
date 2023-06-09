﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VasarolProjekt.ViewModel;

namespace VasarolProjekt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            VasarolViewModel viewModel = new VasarolViewModel();
            window.DataContext = viewModel;
            base.OnStartup(e);
            window.Show();
            
        }
    }
}
