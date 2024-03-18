using Contracts.Implementation;
using MultiplicationApp.TimesTableClass;
using MultiplicationApp.TimesTableClasses;
using MultiplicationApp.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp;

public class MenuChoice
{
	public MenuChoice()
	{
	}

	public void MenuSelector(string userName)
	{
		//Clear console
		Console.Clear();
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("--------------------------------------------------------");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================\n");


		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("Choose an option below to begin....\n");

		//Print Menu Options
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("********NORMAL MODES********");
		Console.WriteLine("----------------------------");
		
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 2 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 3 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 4 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 5 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 6 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 7 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 8 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 9 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 10 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 11 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 12 Times Table Test");
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[-]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 13 Times Table Test\n");

		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.WriteLine("*********EXTRA MODES*********");
		Console.WriteLine("------------------------------");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("[+]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 14. Earth, Wind and Fire (MIXED MODE)");
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("[+]");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine(" 15. SPEED TEST (GOD MODE!!...NO MERCY!!!!)\n");

		//Print Help Menu
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write("[+]");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine(" Press 1 For HELP");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("--------------------------------------------------------\n");



		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write("Enter your option: ");

		//Select an option
		int choice;

		//Create a new Logger object
		Logger logger = new Logger();
		
		//Make sure only a valid menu choice is chosen, so loop continues untill this happens
		do
		{
			//Convert choice to int
			bool validInteger = int.TryParse(Console.ReadLine(), out choice);

			//Result of TryParse
			if (validInteger)
			{
				//Ensure choice is within valid Range
				if (((choice >= 1) && (choice <= 15)))
				{					
					break;
				}
				else
				{
					logger.Warn($"{userName}, you did not enter a valid option number!");
					logger.Info("Enter a valid option number and try again!!\n");
				}
			}
			else
			{
				logger.Warn($"{userName}, you did not enter a valid number!");
				logger.Info("Enter a valid number and try again!!\n");
			}

		} while (true);

		//Create a new ModeChoice Object
		ModeChoice modeChoice = new(userName);

		//Call ChoiceSelector method with ModeChoice instance and choice as param
		modeChoice.ChoiceSelector(choice);

		Console.ReadLine();
	}
}
