using System;
using System.Collections.Generic;
using System.Text;
using TodoTask.Consts;

namespace TodoTask.Models
{
    public class Task
    {
        public int Id { get; set; }
         
        public EnumTaskGroup TaskGroup { get; set; }

        public EnumPriority Priority { get; set; }

        public string Description { get; set; }

        public Repeat Repeat { get; set; }

        public bool Make { get; set; }

        public DateTime Time { get; set; }

        public string DisplayName
        {
            get
            {
                return $"{Description}, {Priority}";
            }
        }



    }

    public class Repeat {
        public int Count { get; set; }
        public EnumRepeatType RepeatType { get; set; }
    }
}
