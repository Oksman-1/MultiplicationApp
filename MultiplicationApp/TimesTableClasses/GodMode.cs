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
using System.Xml.Linq;

namespace MultiplicationApp.TimesTableClass;

//Inherit properties from EarthWindFire Class
public sealed class GodMode : EarthWindFire
{
	public GodMode(ILogger logger, string? UserName, int TimesTableNumber, CommentGenerator commentGenerator) : base(logger, UserName,TimesTableNumber, commentGenerator )
	{
		
	}

	//Use new keyword to Create Test method specific to GodMode Class
	public new void Test()
	{
		Console.ForegroundColor = ConsoleColor.White;

		Console.WriteLine("\n=====================================================\n");

		Console.ForegroundColor = ConsoleColor.White;
		
		Measure(() => t());

		//Measure method t()
		void Measure(Action action)
		{
			Stopwatch.Start();
			action();
			Stopwatch.Stop();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine($"Execution time: {Stopwatch.ElapsedMilliseconds / 1000}s");
		}

		//Main Multiplication Method
		void t()
		{

			for (var i = 0; i <= Randomiser.RandomNumberList1.Count - 1; i++)
			{

				Console.ForegroundColor = ConsoleColor.White;

				Console.Write($"{Randomiser.RandomNumberList2[i]} x {Randomiser.RandomNumberList3[i]} = ");
				int input = 0;

				//Take input from user
				bool validInteger = int.TryParse(Console.ReadLine(), out input);

				if (validInteger)
				{

					if ((Randomiser.RandomNumberList2[i] * Randomiser.RandomNumberList3[i]) == input)
					{
						if (Stopwatch.ElapsedMilliseconds > 8000)
						{
							Console.WriteLine("TOOOOOOOO SLOWWWWWWWWWW");
							
							break;
						}
						_logger.Info(CommentGenerator.ExtremeComments[Randomiser.RandomNumberList1[i]] + "\n");
						Console.ResetColor();
						Score++;
					}
					else
					{
						Console.WriteLine($"WRONG ANSWER!!!!...YOU'LL NEED SOME PRACTICE {UserName}..");
						_logger.Info($"Better Luck Next Time {UserName}!!\n");
						Console.ResetColor();
						break;
					}
				}
				else
				{
					_logger.Warn($"{UserName}, you did not enter a valid number!....You Lost that one Mate!");
					_logger.Info("Ensure to Enter a valid number.....try the next one!!\n");
					Console.ResetColor();
				}
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("````````````````````````````````````````````````````");
				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
			}

			//Call CalculateFactorAndLogResult from Parent
			base.CalculateFactorAndLogResult();
			
		}

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