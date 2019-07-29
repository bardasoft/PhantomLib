﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PhantomLibSamples.UltimateControl
{
    public partial class UltimateControlPage : ContentPage
    {
        public UltimateControlPage()
        {
            InitializeComponent();
        }

        void UltimateEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is PhantomLib.CustomControls.UltimateControl entry)
            {
                entry.ShowError = e.NewTextValue.Length > 10;
            }
        }
    }
}
