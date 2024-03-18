using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MultiplicationApp.UtilityClasses;

public static class ToFile
{


	//Generate Result log
	public static string? ResultLog(DateTime dateTime, string userName, int num, int score, int total, long elapsedTime)
	{
		Random rand = new Random();

		string RandomNum = Convert.ToString((long)Math.Floor(rand.NextDouble() * 12_000_000_000L + 20_000_000_000L));

		return $@"-----------------------------------------------------
Multiplication-Test Result Log-{RandomNum.Substring(1, 6)}-on-{dateTime:MM/dd/yyyy}:
-----------------------------------------------------
> Name Of Participant: {userName}
> Test Type: {num} 
> Date Of Test: {dateTime:D}
> Time Of Test: {dateTime:T}
> Raw Score: {score} out of {total} Marks
> Test Duration: {elapsedTime / 1000}s
> Time-Calculated Percentage Score: {TimeFactor.Result / 100:P}
-----------------------------------------------------
";
	}
}
