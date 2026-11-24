using System.Reflection;

namespace TaskTracker
{
    internal class Program
    {
        static string[] tasks = new string[100];
        static int taskindex = 0;
        static string title,des,due,pri;
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome To Task Tracker");

            while (true)
            {
                //Output
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Update Task");
                Console.WriteLine("3. View Task");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit Application");
                Console.WriteLine("------------------------");
                Console.Write("Enter Your Choice: ");

                //Input
                int usernum = int.Parse(Console.ReadLine());

                switch (usernum)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        UpdateTask();
                        break;
                    case 3:
                        ViewTask();
                        break;
                    case 4:
                        DeleteTask();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Only Choose A Number from 1 to 5.");
                        break;
                }
            
            }
            
        }

        private static void AddTask()
        {
            Console.Write("Enter Your Title: ");
            title = Console.ReadLine();

            Console.Write("Enter Your Description: ");
            des = Console.ReadLine();

            Console.Write("Enter Your Due Date (yy-mm-dd): ");
            due = Console.ReadLine();

            Console.Write("Enter Your Priority (Low-Med-High): ");
            pri = Console.ReadLine();

            tasks[taskindex] = ($"Title: {title} \n" + $"Description: {des} \n" + $"Due Date: {due} \n" + $"Priority: {pri} \n");

            taskindex++;

        }

        private static void ViewTask()
        {
            Console.WriteLine("--Your Tasks is--");
            for (int i = 0; i < taskindex; i++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"Task {i}");
                Console.WriteLine($"{tasks[i]}");
                Console.WriteLine("---------------------------");
            }
        }

        private static void UpdateTask()
        {
            Console.Write("Choose The Task You Want Update: ");
            int taskchoice = int.Parse(Console.ReadLine());
            Console.Write("What is Your Task Statue Right Now? (Pending, in Progress, Completed): ");
            string taskstatus = Console.ReadLine();

            if(taskstatus == "Pending")
            {
                tasks[taskchoice] += ("Task is Pending");
            }
            else if(taskstatus == "in Progress")
            {
                tasks[taskchoice] += ("Task is in Progress");
            }
            else if (taskstatus == "Completed")
            {
                tasks[taskchoice] += ("Task is Completed");
            }
            else
            {
                Console.WriteLine("Try Again Later");
            }

        }

        private static void DeleteTask()
        {
            Console.Write("Choose Task You Want To Delete: ");
            int taskdel = int.Parse(Console.ReadLine());
            tasks[taskdel] = String.Empty;
        }
    }
}
