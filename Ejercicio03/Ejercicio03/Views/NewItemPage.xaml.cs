using System;
using System.Collections.Generic;
using System.ComponentModel;
using Ejercicio03.Models;
using Ejercicio03.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03.Views
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