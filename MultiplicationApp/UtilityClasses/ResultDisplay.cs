using Contracts.Implementation;
using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp.UtilityClasses;

public static class ResultDisplay
{
	public static ILogger Logger { get; private set; } = new Logger();
	
	//Create Result format to display
	public static void Display(int score, List<int> loopCount, long elapsedTime, string name, int timesTableNumber, DateTime dateTime)
	{
		//Return result from TimeFactor class
		var result = TimeFactor.Factor(score, loopCount, elapsedTime);

		//Clear Console
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("========================================================================");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("                            TEST RESULT:");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("------------------------------------------------------------------------");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("========================================================================");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Name Of Participant: ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"{name}");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("--------------------");

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Date Of Test: ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"{dateTime:D}");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("-------------");

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Time Of Test: ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"{dateTime:T}");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("-------------");


		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Raw Score: ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"{name}!, You Got {score} out of {loopCount.Count} Marks.");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("----------");

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Execution Time: ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"{elapsedTime / 1000.0}s");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("---------------");

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Time-Calulated Percentage Score: ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"{result/100:P}");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("-------------------------------");

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.Write("Overall Comment: ");
		Console.ForegroundColor = ConsoleColor.White;

		//Display different message for timesTableNumber 14 and 15
		if (timesTableNumber == 14)
		{
			Console.WriteLine($"Thanks for taking the Mixed Mode Times Table Test......");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"----------------");
		}
		else if (timesTableNumber == 15)
		{
			Console.WriteLine($"Thanks for Participating, Keep Pushing your Limits!!...");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"----------------");
		}
		else
		{
			Console.WriteLine($"Thanks for taking the {timesTableNumber} Times Table Test......");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"----------------");
		}

		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("========================================================================");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("------------------------------------------------------------------------");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("========================================================================");
		Console.WriteLine("");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("========================================================================");


		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("Press 1 To Go Back To Main Menu:  ");
		Console.Write("Press 2 To Exit: ");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("\n========================================================================");

		do
		{
			//take input from user
			string? subChoice = Console.ReadLine();


			if (subChoice == "1")
			{
				//Back to Main Menu
				MenuChoice menuChoice = new();
				menuChoice.MenuSelector(name);
			}
			else if (subChoice == "2")
			{
				//Exit Application
				Environment.Exit(0);
			}
			else
			{
				Logger.Warn($"{name}, you did not enter a valid option number!");
				Logger.Info("Enter a valid option number and try again!!");
			}
		} while (true);
		
	}


}