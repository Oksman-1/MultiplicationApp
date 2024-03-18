using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp.UtilityClasses;

public static class Instructions
{
	//Instructions for Normal Mode
    public static void NormalMode(string userName, int choice)
	{
		//Clear screen
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================================");
		Console.WriteLine("                         INSTRUCTIONS:");
		Console.WriteLine("------------------------------------------------------------------------");
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine($"Hi {userName}, You have chosen to take the {choice} times-table test...");
		Console.WriteLine("Ensure to supply your answers as quickly as possible");
		Console.WriteLine("Note that speed is a factor in determining your overall score...");
		Console.WriteLine("");
		Console.WriteLine($"Have fun {userName}!!");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================================");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Press Enter To Begin");
		Console.ReadLine();
	}

	//Instructions for Mixed Mode
	public static void EarthWindFireMode(string userName)
	{
		//Clear screen
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================================");
		Console.WriteLine("                         INSTRUCTIONS:");
		Console.WriteLine("------------------------------------------------------------------------");
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Hi {userName}, You have chosen to take the MIXED MODE times table test...");
		Console.WriteLine("Note that you are being timed....");
		Console.WriteLine("Ensure to supply your answers as quickly as possible");
		Console.WriteLine("");
		Console.WriteLine($"Have fun {userName}!!");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================================");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Press Enter To Begin");
		Console.ReadLine();
	}

	//Instructions for Speed(God) Mode
	public static void GodMode(string userName)
	{
		//Clear screen
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================================");
		Console.WriteLine("                         INSTRUCTIONS:");
		Console.WriteLine("------------------------------------------------------------------------");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"{userName}!!!, You are in GOD MODE!!.........");
		Console.WriteLine("This is not for the faint of heart!!!");
		Console.WriteLine("SPEED and ACCURACY are your life lines here!.............");
		Console.WriteLine("");
		Console.WriteLine($"GOOD LUCK!!");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("========================================================================");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Press Enter To Begin");
		Console.ReadLine();
	}

	//Instructions for Help
	public static void Help(string userName)
	{
		//Clear screen
		Console.Clear();

		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("=============================================================================");
		Console.WriteLine("                         INSTRUCTIONS:");
		Console.WriteLine("-----------------------------------------------------------------------------");
        Console.WriteLine($"Hi {userName}!!\n");
        Console.WriteLine("Welcome to the Speed Multiplication-Table Test\n");
		Console.WriteLine("This test should hopefully help you with mastery of your Multiplication-Table.");
		Console.WriteLine("Note that time spent on each test is a factor in determining your final score.\n");
		Console.WriteLine("GOOD LUCK.........!!\n");

        Console.WriteLine("-----------------");
        Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("On the Main Menu:");
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("-----------------");

		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[+]");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write(" Press 2 through 13 for the corresponding Numbered Multiplication-Table Test\n");

	
		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[+]");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write(" Press 14 For MIXED Mode\n");

		Console.ForegroundColor = ConsoleColor.White;
		Console.Write("[+]");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.Write(" Press 15 For GOD Mode\n");
		
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine("===============================================================================");
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine("Press The Enter Key To Go Back To Main Menu:");
		Console.ReadLine();
	}
}
