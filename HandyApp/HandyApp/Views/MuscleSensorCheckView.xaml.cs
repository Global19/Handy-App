﻿using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HandyApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MuscleSensorCheckView : ContentPage
    {
        public MuscleSensorCheckView()
        {
            InitializeComponent();

            BindingContext = new ViewModels.MuscleSensorCheckViewModel(UserDialogs.Instance);
        }
    }
}