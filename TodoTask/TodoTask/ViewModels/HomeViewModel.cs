using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoTask.Consts;
using TodoTask.Models;

namespace TodoTask.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        List<Task> today { get; set; }

        public List<Task> Todays
        {
            get => today;
            set
            {
                if (today == value)
                    return;

                today = value;
                OnPropertyChanged();
            }
        }

        public void Init()
        {
            if (today == null || today.Count() == 0)
            {
                Todays = new List<Models.Task>
                {
                    new Models.Task
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
                    new Models.Task
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
                };



                OnPropertyChanged();
                
            }
        }
    }
}
