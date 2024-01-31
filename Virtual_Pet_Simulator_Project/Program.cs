using System.ComponentModel.Design;

namespace CSharpAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainmenu:
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
                int Hunger = 10, Happiness  =2, Health = 3;
                Console.WriteLine($"Activities with {Name}:");
                Actionmenu:
                Console.Write($"1. Feed {Name}\n2. Play with {Name}\n3. Let {Name} rest\n4. Check {Name}'s status\n5. Say bye to {Name}\n\nSelect the activity: ");
                int activity = int.Parse(Console.ReadLine());
                if (activity < 5)
                {
                    if (Health > 10)
                    {
                        Health = 10;
                    }
                    if (Happiness > 10)
                    {
                        Happiness = 10;
                    }
                    switch (activity)
                    {
                        case 1:
                            Console.WriteLine($"\nYou fed {Name}, {Name}'s hunger decreased, health increased.\n");
                            Hunger = Hunger - 1;
                            Health = Health + 1;
                            break;
                        case 2:
                            Console.WriteLine($"\nYou played with {Name}, {Name}'s happiness increased, health decreased.\n");
                            Happiness = Happiness + 1;
                            Health = Health - 1;
                            break;
                        case 3:
                            Console.WriteLine($"\n{Name} is resting, {Name}'s happiness decreased, health increased.\n");
                            Happiness = Happiness - 1;
                            Health = Health + 1;
                            break;
                        case 4:
                            Console.WriteLine($"\nStatus of {Name}:\nHunger : {Hunger}\nHappiness : {Happiness}\nHealth : {Health}\n");
                            break;
                    }
                    if (Hunger < 1)
                    {
                        Hunger = 1;
                    }
                    if(Hunger >=10 || Happiness <= 1 || Health <= 1)
                    {
                        if (Hunger > 10 || Happiness < 1 || Health < 1)
                        {
                            Console.WriteLine($"{Name} is no more :(");
                            Console.WriteLine($"\nBye, bye!!!");
                        }
                        else
                        {
                            if (Hunger == 10)
                            {
                                Console.WriteLine($"Warning!!! {Name} is extremely hungry, please feed him.");
                            }
                            if (Health == 1)
                            {
                                Console.WriteLine($"Warning!!! {Name} is not at all healthy, let him take rest.");
                            }
                            if (Happiness == 1)
                            {
                                Console.WriteLine($"Warning!!! {Name} is upset, play with him.");
                            }
                            goto Actionmenu;
                        }
                    }
                    else
                    {
                        Console.Write($"Do you like to do any other activity with {Name} (Yes/No)? ");
                        String UserResponse = Console.ReadLine();
                        if (UserResponse.ToLower() == "yes")
                        {
                            goto Actionmenu;
                        }
                        else
                        {
                            Console.WriteLine($"\nBye, bye!!!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\nBye, bye!!!");
                }
            }
            else
            {
                Console.WriteLine("\nWrong selection! Please select again.\n");
                goto Mainmenu;
            }
        }
    }
}