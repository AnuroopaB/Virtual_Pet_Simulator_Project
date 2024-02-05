namespace CSharpAssignment
{
	class Program
	{
		static void Main(string[] args)
		{	
			Console.Write("Welcome to Virtual Pet Store!\n-----------------------------\nThese are the ");
			Petmenu:
			Console.WriteLine("Available pets:");
            //Pet selection menu
            Console.Write("1. Dog\n2. Cat\n3. Rabbit\n4. Parrot\n\nEnter your selection: ");
			int petSelection = int.Parse(Console.ReadLine());
			String petType = "";
			switch (petSelection)
			{
				case 1:
					petType = "Dog";
					break;
				case 2:
					petType = "Cat";
					break;
				case 3:
					petType = "Rabbit";
					break;
				case 4:
					petType = "Parrot";
					break;
			}
			if (petType != "")
			{
				Console.Write($"\nCongrats, Your new buddy is a {petType}.\n\nWhat would you like to call your new friend? ");
				//Naming pet
				String petName = Console.ReadLine();
				Console.WriteLine($"\nWelcome dear {petName}, we are so happy to be with you!\n");
				int Hunger = 6, Happiness = 5, Health =5, Hours = 0;
				//Activities with pet
				Console.Write($"Activities with {petName}:\n--------------------");
				Activitymenu:
				Console.Write($"\n1. Feed {petName}\n2. Play with {petName}\n3. Let {petName} rest\n4. Check {petName}'s status\n5. Say bye to {petName}\n\nSelect the activity: ");
				int activity = int.Parse(Console.ReadLine());
				//If user selects any activity 
				if (activity > 0 && activity < 5)
				{
					switch (activity)
					{
						case 1:
							//Feed pet
							Console.WriteLine($"\nYou fed {petName}, {petName}'s hunger decreased, health increased.");
							Hunger -= 1;
							Health += 1;
							Happiness -= 1;
							Hours += 1;
							break;
						case 2:
                            //Play with pet
                            if (Hunger == 10)
							{
								Console.WriteLine($"\nWarning!!! {petName} has send you a message \"I cannot play when I am starving\".");
								Health -= 1;
                                if (Happiness == 1)
								{
                                    Health -= 1;
                                }
                            }
							else
							{
								Happiness += 1;
								Hunger += 1;
                                Hours += 1;
                                Console.WriteLine($"\nYou played with {petName}, {petName}'s happiness increased, hunger increased.");
                            }
							break;
						case 3:
							//Rest mode
							if (Happiness == 1)
							{
								Console.WriteLine($"\nWarning!!! {petName} has send you a message \"I cannot rest when I am depressed\".");
								Health -= 1;
								if (Hunger == 10)
								{
									Health -= 1;
								}
							}
							else
							{
								Happiness -= 1;
								Health += 1;
								Hunger += 1;
								Hours += 1;
								Console.WriteLine($"\n{petName} is resting, {petName}'s happiness decreased, health increased.");
							}
							break;
						case 4:
                            //Check status of pet
                            Console.WriteLine($"\nStatus of {petName}:\nHunger : {Hunger}\nHappiness : {Happiness}\nHealth : {Health}");
							break;
					}
                    //When pet's health is down
                    if (Health <= 1)
					{
						Console.Write($"{petName} is no more :( . ");
						if (activity == 2)
						{
							Console.Write($"{petName}'s health went down due to starvation. ");
						}
						else if (activity == 3)
						{
							Console.Write($"{petName}'s health went down due to depression. ");
						}
						else
						{
							Console.Write($"{petName}'s health went down. ");
						}
						Console.WriteLine($"You should have been more careful!\nThankyou for successfully spending {Hours} hours with {petName}, Bye...bye!!!");
						return;
					}
					//Ideal conditions or positive extremes 
					if (Hunger < 1)
					{
						Hunger = 1;
						Console.WriteLine($"\n{petName} is feeling full!");
					}
					if (Health >= 10)
					{
						Health = 10;
						Console.WriteLine($"\n{petName} is super healthy!");
					}
					if (Happiness >= 10)
					{
						Happiness = 10;
						Console.WriteLine($"\n{petName} is very happy!");
					}
					//Warning or critical conditions
					if (Hunger >= 10 || Happiness <= 1 || Health <= 3 || Hunger == 8 || Hunger == 9 || Happiness == 3 || Happiness == 2)
					{
						if (Hunger >= 10)
						{
							Hunger = 10;
							Console.WriteLine($"\nWarning!!! {petName} is starving, feed him.");
						}
						if (Happiness <= 1)
						{
							Happiness = 1;
							Console.WriteLine($"\nWarning!!! {petName} is depressed, play with him.");
						}
                        if (Hunger == 8 || Hunger == 9)
						{
							Console.WriteLine((Hunger == 8) ? $"\nWarning!!! {petName} is little hungry, feed him." : $"\nWarning!!! {petName} is very hungry, feed him.");
						}
						if (Happiness == 3 || Happiness == 2)
						{
							Console.WriteLine((Happiness == 3) ? $"\nWarning!!! {petName} is little upset, play with him." : $"\nWarning!!! {petName} is very upset, play with him.");
                        }
                        if (Health <= 3)
                        {
                            Console.WriteLine($"\nWarning!!! {petName} is not at all healthy, let him take rest or feed him.");
                        }
                        goto Activitymenu;
						}
					else
					{
						//When Status is normal, new activity selection
						Console.Write($"\nDo you like to do any other activity with {petName} (Yes/No)? ");
						String UserResponse = Console.ReadLine();
						if (UserResponse.ToLower() == "yes")
						{
							goto Activitymenu;
                        }
                        //No more interested in selecting an activity
                        else
                        {
							Console.WriteLine($"\nThankyou for successfully spending {Hours} hours with {petName}, Bye...bye!!!");
						}
					}
				}
				else
				{
					//When 'Say Bye to pet' is selected
					if (activity == 5)
					{
						Console.WriteLine($"\nThankyou for successfully spending {Hours} hours with {petName}, Bye...bye!!!");
					}
					//When wrong activity is selected
					else
					{
						Console.Write($"\nOops, wrong action! Try again.\n\nActivities with {petName}:\n--------------------");
						goto Activitymenu;
					}
				}
			}
            //When wrong Pet is selected
            else
            {
				Console.WriteLine("\nWrong pet selection! Please select again.\n");
				goto Petmenu;
			}
		}
	}
}