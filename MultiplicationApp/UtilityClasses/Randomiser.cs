using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp.UtilityClasses;

public sealed class Randomiser
{
	//Instantiate Random Lists
	public List<int> RandomNumberList1 { get; set; } = new List<int>();
	public  List<int> RandomNumberList2 { get; set; } = new List<int>();
	public  List<int> RandomNumberList3 { get; set; } = new List<int>();


	public Randomiser()
	{
		//Create a Random object
		Random rand = new Random();

		//Generate random numbers
		for (int i = 0; i < 20; i++)
		{
			RandomNumberList1.Add(rand.Next(minValue: 1, maxValue: 15));
			RandomNumberList2.Add(rand.Next(minValue: 5, maxValue: 15));
			RandomNumberList3.Add(rand.Next(minValue: 6, maxValue: 15));
		}	

	}

}
