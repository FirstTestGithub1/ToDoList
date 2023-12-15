class Program {
    static List<string> todoList = new List<string>();

    static void Main() {
        Console.WriteLine("Welcome to the To Do List!");

        while (true) {
            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    AddTask();
                    break;
                case "2":
                    MarkAsCompleted();
                    break;
                case "3":
                    ShowTasks();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu() {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Mark Task as Completed");
        Console.WriteLine("3. Show Tasks");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    static void AddTask() {
        Console.Write("Enter the task: ");
        string task = Console.ReadLine();
        todoList.Add(task);
        Console.WriteLine("Task added successfully!");
    }

    static void MarkAsCompleted() {
        if (todoList.Count == 0) {
            Console.WriteLine("No tasks available.");
            return;
        }

        ShowTasks();

        Console.Write("Enter the number of the task to mark as completed: ");
        int index = Convert.ToInt32(Console.ReadLine())-1;
        Console.WriteLine(index);
        Console.WriteLine(todoList.Count);
       if  (index >= 0 && index <= todoList.Count) {
            Console.WriteLine($"Task '{todoList[index]}' marked as completed!");
            todoList.RemoveAt(index);
        }
        else {
            Console.WriteLine("Invalid index. Please try again.");
        }
    }

    static void ShowTasks() {
        Console.Clear();
        if (todoList.Count == 0) {
            Console.WriteLine("No tasks available.");
            Console.WriteLine("Press any key to return for the main menu.");
            Console.ReadLine();
        }
        else {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < todoList.Count; i++) {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }
}
