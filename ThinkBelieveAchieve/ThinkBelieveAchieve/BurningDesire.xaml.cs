﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThinkBelieveAchieve
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BurningDesire : ContentPage
    {
        public BurningDesire()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Saved", "Your BurningDesire has been saved", "Great!");
        }
    }
}