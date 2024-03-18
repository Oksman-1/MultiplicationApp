using Contracts.Implementation;
using Contracts.Interfaces;
using MultiplicationApp.TimesTableClass;
using MultiplicationApp.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp.TimesTableClasses;

public class ModeChoice
{
	public string? UserName { get; set; }
	public CommentGenerator CommentGenerator { get; set; } = new CommentGenerator();
	public MenuChoice MenuChoice { get; set; } = new MenuChoice();
	public ModeChoice(string? userName)
	{
		UserName = userName;
	}

	//Choice Selector
	public void ChoiceSelector(int choice)
	{
		//Instantiate Logger class
		ILogger logger = new Logger();
		//Determine Choice Action
		if ((choice >= 2) && (choice <= 13))
		{
			//Display Normal Mode Instructions
			Instructions.NormalMode(UserName, choice);
			//launch animation
			Animation();
			//Instantiate TimesTable class
			TimesTable TimesTableTest = new(logger, choice, UserName);
			TimesTableTest.Test();
		}
		else if (choice == 14)
		{
			//Display Mixed Mode Instructions
			Instructions.EarthWindFireMode(UserName);
			//launch animation
			Animation();
			//Instantiate EarthWindFire class
			EarthWindFire earthWindFire = new(logger, UserName, choice, CommentGenerator);
			earthWindFire.Test();
		}
		else if(choice == 15)
		{
			//Display God Mode Instructions
			Instructions.GodMode(UserName);
			//launch animation
			Animation();
			//Instantiate GodMode class
			GodMode godMode = new(logger, UserName, choice, CommentGenerator);
			godMode.Test();
		}
		else
		{
			//Display Help Instructions
			Instructions.Help(UserName);
			MenuChoice menuChoice = new();
			menuChoice.MenuSelector(UserName);
		}

		//Create Opening Animation
		 void Animation()
		{
			Console.Clear();
			Console.WriteLine("=====================================================\n");
			for (int i = 0; i <= 12; i++)
			{

				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write($"->");					
				Console.Write("");
				Thread.Sleep(10);

				Console.ForegroundColor = ConsoleColor.Magenta;
				Console.Write($"*");				
				Console.Write(" ");
				Thread.Sleep(20);
			}
		}		

	}

}
