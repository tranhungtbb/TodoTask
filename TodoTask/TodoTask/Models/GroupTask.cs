using System;
using System.Collections.Generic;
using System.Text;
using TodoTask.Consts;

namespace TodoTask.Models
{
    public class GroupTask : List<Task>
    {
        public EnumTaskGroup Group { get; set; }
        public List<Task> Items => this;
    }
}
