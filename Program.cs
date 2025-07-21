bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("===== DATA STRUCTURES PRACTICE =====");
    Console.WriteLine("1. Stack");
    Console.WriteLine("2. Queue");
    Console.WriteLine("3. Linked List");
    Console.WriteLine("4. Binary Tree");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option: ");

    string? input = Console.ReadLine();

    switch (input)
    {
        case "1":
            StackDemo.Run();
            break;
        case "2":
            QueueDemo.Run();
            break;
        case "3":
            LinkedListDemo.Run();
            break;
        case "4":
            BinaryTreeDemo.Run();
            break;
        case "5":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid choice. Press any key to try again.");
            Console.ReadKey();
            break;
    }
}

Console.WriteLine("Goodbye!");
