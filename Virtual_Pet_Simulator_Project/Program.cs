namespace CSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Available pets:");
            Console.Write("1. Dog\n2. Cat\n3. Rabbit\n\nEnter your selection: ");
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
            }
            if (a != "")
            {
                Console.WriteLine($"\nCongrats, Your new buddy is a {a}.");
            }
            else
            {
                Console.WriteLine("\nWrong selection!");
            }
        }
    }
}