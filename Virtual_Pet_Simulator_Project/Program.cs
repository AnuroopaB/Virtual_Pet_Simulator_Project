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
                Console.WriteLine($"\nWelcome dear {Name}, we are so happy to be with you!");
            }
            else
            {
                Console.WriteLine("\nWrong selection!");
                //goto
            }
        }
    }
}