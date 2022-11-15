using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TodoTask.Controls
{	
	public partial class AddTaskControl
	{
        public AddTaskControl()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.IsOpen = false;
        }

    }
}