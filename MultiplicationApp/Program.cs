using Contracts.Implementation;
using Contracts.Interfaces;
using MultiplicationApp;
using MultiplicationApp.TimesTableClass;
using MultiplicationApp.TimesTableClasses;
using MultiplicationApp.UtilityClasses;

Console.Title = "MULTIPLICATION TEST";
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===================================================MULTIPLICATION TEST==================================================\n");
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------\n");

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Enter your FirstName: ");
Console.ResetColor();

//Take UserName
string? userName = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Password: ");
Console.ResetColor();

//Take User Password
string? psswd = Console.ReadLine();


//Create a new MenuChoice Object
MenuChoice menuChoice = new();

//Call MenuSelector method with MenuChoice instance and name of user as param
menuChoice.MenuSelector(userName);












