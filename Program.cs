using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class Program
	{
		static void Main(string[] args)
		{//manager: will talk to the children or parents when it needs to.
			do
			{
				Console.WriteLine("Welcome to Rock Paper Scissors!");
				Console.WriteLine("Please Enter Your Name:");
				//string input = (Console.ReadLine());
				Console.WriteLine(" what team do you want to play against? The Lannisters or the Starks");
				string input2 = (Console.ReadLine());
				input2 = r.GetRoshambo(0);

				//string a = "Lannisters";
				//string b = "Stark";

				Random rando = new Random();
				Roshambo x = new Roshambo();
				string rock = x.GetRoshambo(0);
				Console.WriteLine(rock);
				string paper = x.GetRoshambo(1);
				Console.WriteLine(paper);
				String scissors = x.GetRoshambo(2);
				Console.WriteLine(scissors);

				Player q = new RandoPlayer("steph", rando);
				
				Player t = new RockPlayer("starks");
				Console.WriteLine(b.GetName() + " throws out " + b.GetRoshambo());

				

			} while (Continue() == true);

			//if (input2 == a)
			//{
			//Console.WriteLine("Time to Play!");
			//Console.WriteLine("Rock, Paper or Scissors?(R/P/S)");
			//string input3 = (Console.ReadLine());
			//	if (input3 == "R" || input3 == "P" || input3 == "S")
			//	{
			//		Random newThrow = new Random();
			//		int myThrow = newThrow.Next(1, 3);
			//		switch (myThrow)
			//		{
			//			case 1:
			//				Console.WriteLine("Lannisters throw Rock");
			//				return;
			//			case 2:
			//				Console.WriteLine("Lannisters throw Paper");
			//				return;
			//			case 3:
			//				Console.WriteLine("Lannisters throw Scissors");
			//				return;
			//			default:
			//				return;
			//		}
			//	}
			//	else if (input2 == b)
			//	{
			//		Console.WriteLine("Time to Play!");
			//		Console.WriteLine("Rock, Paper or Scissors?(R/P/S)");
			//		string input4 = (Console.ReadLine());
			//		Console.WriteLine("Rock. House Stark Always Wins.");
			//	}

			//}
		

		}
			public static Boolean Continue()
				{
					Boolean run;
					Console.WriteLine("Play Again: y/n?");
					string answer = Console.ReadLine();

					if ((answer == "Y") || (answer == "y"))
					{
						run = true;
					}
					else if ((answer == "N") || (answer == "n"))
					{
						run = false;
						Console.WriteLine("Later.");
					}
					else
					{
						Console.WriteLine("Yadda Yadda");
						run = Continue();
					}
					return run;

				}
		}	
	}

	

