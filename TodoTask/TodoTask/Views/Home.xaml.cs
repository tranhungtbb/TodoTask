using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoTask.Consts;
using TodoTask.Models;
using TodoTask.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        HomeViewModel _vm;

        public Home()
        {
            InitializeComponent();
            _vm = new HomeViewModel();
            BindingContext = _vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _vm.Init();
            base.OnPropertyChanged();
        }
    }
}