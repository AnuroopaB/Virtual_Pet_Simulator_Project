//using System.ComponentModel.Design;

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
				int Hunger = 9, Happiness  =2, Health = 3;
				Console.Write($"Activities with {Name}:");
				Actionmenu:
				Console.Write($"\n1. Feed {Name}\n2. Play with {Name}\n3. Let {Name} rest\n4. Check {Name}'s status\n5. Say bye to {Name}\n\nSelect the activity: ");
				int activity = int.Parse(Console.ReadLine());
				if (activity > 0 && activity < 5)
				{
					switch (activity)
					{
						case 1:
							Console.WriteLine($"\nYou fed {Name}, {Name}'s hunger decreased, health increased.");
							Hunger -= 1;
							Health += 1;
							//Happiness -= 1;
							break;
						case 2:
							if (Hunger == 10)
							{
								Console.WriteLine($"\nWarning!!! {Name} has send you a message \"I cannot play when I am starving\".");
								Health -= 1;
							}
							else
							{
								Happiness += 1;
								Hunger += 1;
								Console.WriteLine($"\nYou played with {Name}, {Name}'s happiness increased, hunger increased.");
							}
							break;
						case 3:
							if (Happiness == 1)
							{
								Console.WriteLine($"\nWarning!!! {Name} has send you a message \"I cannot rest when I am depressed\".");
								Health -= 1;
							}
							else
							{
								Happiness -= 1;
								Health += 1;
								Hunger += 1;
								Console.WriteLine($"\n{Name} is resting, {Name}'s happiness decreased, health increased.");
							}
							break;
						case 4:
							Console.WriteLine($"\nStatus of {Name}:\nHunger : {Hunger}\nHappiness : {Happiness}\nHealth : {Health}");
							break;
					}
					if (Health == 1)
					{
						Console.Write($"{Name} is no more :( . ");
						if (activity == 2)
						{
							Console.Write($"His health went down due to starvation. ");
						}
						else if (activity == 3)
						{
							Console.Write($"His health went down due to depression. ");
						}
						else
						{
							Console.Write($"His health went down. ");
						}
						Console.WriteLine($"You should have been more careful!\nBye, bye!!!");
						return;
					}
					if (Hunger < 1)
					{
						Hunger = 1;
						Console.WriteLine($"\n{Name} is feeling full!");
					}
					if (Health >= 10)
					{
						Health = 10;
						Console.WriteLine($"\n{Name} is super healthy!");
					}
					if (Happiness >= 10)
					{
						Happiness = 10;
						Console.WriteLine($"\n{Name} is very happy!");
					}
					if (Hunger >= 10 || Happiness <= 1 || Health <= 3 || Hunger == 8 || Hunger == 9 || Happiness == 3 || Happiness == 2)
					{
						if (Hunger >= 10)
						{
							Hunger = 10;
							Console.WriteLine($"\nWarning!!! {Name} is starving, feed him.");
						}
						if (Happiness <= 1)
						{
							Happiness = 1;
							Console.WriteLine($"\nWarning!!! {Name} is depressed, play with him.");
						}
                        if (Hunger == 8 || Hunger == 9)
						{
							string r = (Hunger == 8) ? $"\nWarning!!! {Name} is little hungry, feed him." : $"\nWarning!!! {Name} is very hungry, feed him.";
							Console.WriteLine(r);
						}
						if (Happiness == 3 || Happiness == 2)
						{
							string r1 = (Happiness == 3) ? $"\nWarning!!! {Name} is little upset, play with him." : $"\nWarning!!! {Name} is very upset, play with him.";
							Console.WriteLine(r1);
                        }
                        if (Health <= 3)
                        {
                            Console.WriteLine($"\nWarning!!! {Name} is not at all healthy, let him take rest or feed him.");
                        }
                        goto Actionmenu;
						}
					else
					{
						Console.Write($"\nDo you like to do any other activity with {Name} (Yes/No)? ");
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
					if (activity == 5)
					{
						Console.WriteLine($"\nBye, bye!!!");
					}
					else
					{
						Console.WriteLine($"\nOops, wrong action! Try again.\n\nActivities with {Name}:\n");
						goto Actionmenu;
					}
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