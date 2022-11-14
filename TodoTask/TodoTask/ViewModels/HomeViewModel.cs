using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TodoTask.Consts;
using TodoTask.Models;

namespace TodoTask.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<GroupTask> _groupTask { get; set; }

        public ObservableCollection<GroupTask> GroupTask
        {
            get => _groupTask;
            set
            {
                if (_groupTask == value)
                    return;

                _groupTask = value;
                OnPropertyChanged();
            }
        }

        public void Init()
        {
            if (_groupTask == null || _groupTask.Count() == 0)
            {
                GroupTask = new ObservableCollection<GroupTask>{
                new GroupTask {
                    Group = EnumTaskGroup.Today,
                    Items = {
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
                            TaskGroup = EnumTaskGroup.Today,
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
                Items = {
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
                        TaskGroup = EnumTaskGroup.Inbox,
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

                OnPropertyChanged();

            }
        }
    }
}
