using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_Console_App.Model
{
    public class TaskManager
    {
       
    
            private List<TaskItem> tasks = new List<TaskItem>();
            private int nextId = 1;

            public void AddTask(string title)
            {
                tasks.Add(new TaskItem { Id = nextId++, Title = title, IsCompleted = false });
            }

            public void ShowTasks()
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.Id}. {task.Title} - {(task.IsCompleted ? "✅" : "❌")}");
                }
            }

            public void MarkDone(int id)
            {
                var task = tasks.FirstOrDefault(t => t.Id == id);
                if (task != null)
                {
                    task.IsCompleted = true;
                }
            }
        }

    }


