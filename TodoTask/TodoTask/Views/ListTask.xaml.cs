using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TodoTask.Consts;
using TodoTask.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoTask.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTask : ContentPage
    {
        ViewModels.HomeViewModel _vm;
        public ListTask()
        {
            InitializeComponent();
            _vm = new ViewModels.HomeViewModel();
            _vm.Init();
            BindingContext = _vm;
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            base.OnPropertyChanged();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("Click");
        }


    }
}