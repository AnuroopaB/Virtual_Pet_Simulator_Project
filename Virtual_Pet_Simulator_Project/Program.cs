namespace CSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available pets:");
            Console.Write("1. Dog\n2. Cat\n3. Rabbit\n4. Parrot\n\nEnter your selection: ");
            int selection = int.Parse(Console.ReadLine());
            String a = "";
            switch (selection)
            {
                case 1:
                    a = "Dog";
                    break;
                case 2:
                    a = "Cat";
                    break;
                case 3:
                    a = "Rabbit";
                    break;
                case 4:
                    a = "Parrot";
                    break;
            }
            if (a != "")
            {
                Console.Write($"\nCongrats, Your new buddy is a {a}.\n\nWhat would you like to call your new friend? ");
                String Name = Console.ReadLine();
                Console.WriteLine($"\nWelcome dear {Name}, we are so happy to be with you!\n");
                Console.Write($"Activities with {Name}:\n1. Feed {Name}\n2. Play with {Name}\n3. Let {Name} rest\n4. Check {Name}'s status\n5. Say bye to {Name}\n\nSelect the activity: ");
                int activity = int.Parse(Console.ReadLine());
                switch (activity)
                {
                    case 1:
                        Console.WriteLine($"\nYou fed {Name}, {Name}'s hunger decreased, health increased.");
                        break;
                    case 2:
                        Console.WriteLine($"\nYou played with {Name}, {Name}'s happiness increased, health decreased.");
                        break;
                    case 3:
                        Console.WriteLine($"\n{Name} is resting, {Name}'s happiness decreased, health increased.");
                        break;
                    case 4:
                        Console.WriteLine($"\nStatus of {Name}");
                        break;
                    case 5:
                        Console.WriteLine($"\nBye, bye!!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nWrong selection!");
                //goto
            }
        }
    }
}