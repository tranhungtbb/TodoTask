using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using BottomSheetXF.Implementations;
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

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (!CustomBottomSheet.IsInitiated)
            {
                CustomBottomSheet.Init(height, width);
            }
        }


        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            _vm.IsOpen = ! _vm.IsOpen;
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            _vm.IsOpen = false;
        }


        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditTask(1));

        }

        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            _vm.IsOpen = true;
        }
    }
}