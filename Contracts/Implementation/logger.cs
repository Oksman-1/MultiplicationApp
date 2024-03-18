using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Implementation;

public class Logger : ILogger
{
	//Log Error to the Console
	public void Error(string logText)
	{
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine($"[NOO!:] {logText} ");
	}

	//Log instruction to the Console
	public void Info(string logText)
	{
		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine($"[OK!:] {logText} ");	

	}

	//Log warning to the Console
	public void Warn(string logText)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"[OOPS!:] {logText} ");

	}

	//Write result to an external file
	public void WriteLog(string strLog)
	{
		StreamWriter log;
		FileStream fileStream;
		DirectoryInfo logDirInfo;
		FileInfo logFileInfo;
		
		//Base of file path i.e C:\Users\Documents
		var logFileBase = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Users{Path.DirectorySeparatorChar}{Environment.UserName}{Path.DirectorySeparatorChar}Documents{Path.DirectorySeparatorChar}MultiplicationAppScores{Path.DirectorySeparatorChar}";

		//To create a log-file per individual test
		//Random rand = new Random();
		//string RandomNum = Convert.ToString((long)Math.Floor(rand.NextDouble() * 12_000_000_000L + 20_000_000_000L));

		//Full file path composed of the Base and a daily changing date to generate daily logs
		string logFilePath = $"{logFileBase} Score-{System.DateTime.Today.ToString("MM-dd-yyyy")}.txt";

		//Get Info on the file path
		logFileInfo = new FileInfo(logFilePath);

		//Get Info on directory of file
		logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);

		//create directory if it dosen't exist
		if (!logDirInfo.Exists) logDirInfo.Create();

		//Check if file already exists
		if (!logFileInfo.Exists)
		{
			//Create file if it doesn't already exist 
			fileStream = logFileInfo.Create();
		}
		else
		{
			//Simply append new log if file already exists
			fileStream = new FileStream(logFilePath, FileMode.Append);
		}

		//create StreamWriter Object
		log = new StreamWriter(fileStream);

		//Write Log
		log.WriteLine(strLog);

		//Release resources after closing
		log.Close();
	}
}
