using System;
using System.Collections.Generic;
using System.ComponentModel;
using Semana09.Models;
using Semana09.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana09.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}