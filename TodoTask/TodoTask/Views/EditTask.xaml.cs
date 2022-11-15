using System;
using System.Collections.Generic;
using TodoTask.ViewModels;
using Xamarin.Forms;

namespace TodoTask.Views
{	
	public partial class EditTask : ContentPage
	{
		public EditTaskViewModel _vm;

		public EditTask() {
            InitializeComponent();
        }

        public EditTask(int Id)
		{
			InitializeComponent();
			_vm = new EditTaskViewModel();
			_vm.Id = Id;
			BindingContext = _vm;
		}
	}
}

