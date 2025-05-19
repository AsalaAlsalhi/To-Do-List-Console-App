using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Console_App.Model
{
    public class TaskItem
    {
       
            public int Id { get; set; }
            public string Title { get; set; }
            public bool IsCompleted { get; set; }
        }
    }

