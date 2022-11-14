using System;
using System.Collections.Generic;
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
        public List<GroupTask> GroupTask { get; set; }

        public ListTask()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GroupTask = new List<GroupTask>{
                new GroupTask {
                    Group = EnumTaskGroup.Today,
                    Tasks = new List<Task> {
                        new Task
                        {
                            Id = 1,
                            TaskGroup = EnumTaskGroup.Today,
                            Priority = EnumPriority.Hight,
                            Description = "Watch 1 design masterclass",
                            Repeat = new Repeat
                            {
                                Count = 2,
                                RepeatType = EnumRepeatType.Month
                            },
                            Make = true,
                            Time = DateTime.Now
                        },
                        new Task
                        {
                            Id = 1,
                            TaskGroup = EnumTaskGroup.Upcoming,
                            Priority = EnumPriority.Medium,
                            Description = "Feed the cat",
                            Repeat = new Repeat
                            {
                                Count = 1,
                                RepeatType = EnumRepeatType.Week
                            },
                            Make = true,
                            Time = DateTime.Now.AddHours(20).AddMinutes(10)
                        }
                    }
                },
            new GroupTask
            {
                Group = EnumTaskGroup.Inbox,
                Tasks = new List<Task> {
                    new Task
                    {
                        Id = 1,
                        TaskGroup = EnumTaskGroup.Inbox,
                        Priority = EnumPriority.Hight,
                        Description = "Update portfolio",
                        Repeat = new Repeat
                        {
                            Count = 2,
                            RepeatType = EnumRepeatType.Day
                        },
                        Make = true,
                        Time = DateTime.Now
                    },
                    new Task
                    {
                        Id = 1,
                        TaskGroup = EnumTaskGroup.Inbox,
                        Priority = EnumPriority.Medium,
                        Description = "Buy christmas presents for family, visit website for ideas",
                        Repeat = new Repeat
                        {
                            Count = 2,
                            RepeatType = EnumRepeatType.Week
                        },
                        Make = true,
                        Time = DateTime.Now
                    },
                    new Task
                    {
                        Id = 1,
                        Priority = EnumPriority.Low,
                        Description = "Lunch",
                        Repeat = new Repeat
                        {
                            Count = 1,
                            RepeatType = EnumRepeatType.Day
                        },
                        Make = true,
                        Time = DateTime.Now
                    }
                }
            }};
            base.OnPropertyChanged();
        }
    }
}