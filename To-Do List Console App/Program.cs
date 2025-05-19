using To_Do_List_Console_App.Model;

namespace To_Do_List_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            while (true)
            {
                Console.WriteLine("1. Add Task\n2. Show Tasks\n3. Mark Task as Done\n4. Exit");
                var choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Enter task: ");
                    var title = Console.ReadLine();
                    manager.AddTask(title);
                }
                else if (choice == "2")
                {
                    manager.ShowTasks();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter task ID to mark as done: ");
                    var id = int.Parse(Console.ReadLine());
                    manager.MarkDone(id);
                }
                else if (choice == "4")
                {
                    break;
                }
            }
        }
    }
}

