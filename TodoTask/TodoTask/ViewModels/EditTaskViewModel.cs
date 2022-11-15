using System;
using Xamarin.Forms;

namespace TodoTask.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public class EditTaskViewModel : BaseViewModel
	{
		private TodoTask.Models.Task _task { get; set; }

		public TodoTask.Models.Task Task {
			get => _task;
			set {
				_task = value;
				OnPropertyChanged();
			}
		}


        private int _id { get; set; }

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }


        public EditTaskViewModel()
		{

		}
	}
}

