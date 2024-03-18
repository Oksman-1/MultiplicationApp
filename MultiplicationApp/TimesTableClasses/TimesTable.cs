using Contracts.Implementation;
using Contracts.Interfaces;
using MultiplicationApp.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MultiplicationApp.TimesTableClass;

public class TimesTable
{
	public  ILogger _logger;
	public int Score { get; set; }
	public int TimesTableNumber { get; set; }
	public string? UserName { get; set; }
	public DateTime DateTime { get; set; } = DateTime.Now;
	public Randomiser Randomiser { get; set; } = new Randomiser();	
	public Stopwatch Stopwatch { get; set; } = new Stopwatch();

	public TimesTable(ILogger logger, int timesTableNumber, string? userName)
	{	
		_logger = logger;
		TimesTableNumber = timesTableNumber;
		UserName = userName;		
	}

	//Main Test method
     public void Test()
	{
		Console.ForegroundColor = ConsoleColor.White;

		Console.WriteLine("\n=====================================================\n");

		Console.ForegroundColor = ConsoleColor.White;
		Score = 0;
		
		Measure(() => t());

		//Measure method t()
		void Measure(Action action)
		{
			Stopwatch.Start();
			action();
			Stopwatch.Stop();
			Console.ForegroundColor = ConsoleColor.White;
			
			//Set a limit of 30s to display message
			if (Stopwatch.ElapsedMilliseconds > 30000)
			{
				Console.WriteLine("YOU WERE QUITE SLOW");
				Console.WriteLine("TRY TO BE FASTER NEXT TIME....");
			}
			else { Console.WriteLine("YOU'RE A QUICK FINGER HUH.....GREAT!!!!"); }

			Console.WriteLine($"Execution time: {Stopwatch.ElapsedMilliseconds / 1000}s");
		}
		
		//Main Multiplication Method
		void t()
		{
			foreach (var RandomNumber in Randomiser.RandomNumberList1)
			{
				Console.Write($"{TimesTableNumber} x {RandomNumber} = ");
				int input = 0;

				//Take input from user
				bool validInteger = int.TryParse(Console.ReadLine(), out input);

				if (validInteger)
				{
					if ((TimesTableNumber * RandomNumber) == input)
					{
						_logger.Info($"You got That right {UserName}!!\n");
						Console.ResetColor();
						Score++;
					}
					else
					{
						_logger.Error($"Nope! Try again {UserName}!!\n");
						Console.ResetColor();
					}
				}
				else
				{
					_logger.Warn($"{UserName}, you did not enter a valid number!....You Lost that one Mate!");
					_logger.Info("Ensure to Enter a valid number.....try the next one!!\n");
					Console.ResetColor();
				}
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("*******************************************************");
				Console.ResetColor();
			}

			//Call CalculateFactorAndLogResult Method
			CalculateFactorAndLogResult();
		}

		//Call SubChoice Method
		SubChoice();
	 }	

	public void CalculateFactorAndLogResult()
	{
		try
		{
			//Call Time Factor to calculate Time-Based score
			TimeFactor.Factor(Score, Randomiser.RandomNumberList1, Stopwatch.ElapsedMilliseconds);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
		}

		//Prepare Log result
		var ResultLogText = ToFile.ResultLog(DateTime, UserName, TimesTableNumber, Score, Randomiser.RandomNumberList1.Count, Stopwatch.ElapsedMilliseconds);

		//Log result to external file
		_logger.WriteLog(ResultLogText);
	}

	
	//Display Subchoice
	public void SubChoice()
	{
		Console.WriteLine("==========================================================================");

		Console.WriteLine($"THANKS FOR TAKING THE TEST.......");

		Console.WriteLine("==========================================================================");

		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("Press 0 to check your score:  ");
		Console.Write("Press 1 to take the same test again:  ");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("\n==========================================================================");

		do
		{
			//Take choice as input from user
			string? subChoice = Console.ReadLine();

			if (subChoice == "0")
			{
				ResultDisplay.Display(Score, Randomiser.RandomNumberList1, Stopwatch.ElapsedMilliseconds, UserName, TimesTableNumber, DateTime);
				break;

			}
			else if (subChoice == "1")
			{
				Console.Clear();
				Score = 0;
				Stopwatch.Reset();
				Test();
				break;
			}
			else
			{
				_logger.Warn($"{UserName}, you did not enter a valid option number!");
				_logger.Info("Enter a valid option number and try again!!");
			}
		} while (true);
	}


}
