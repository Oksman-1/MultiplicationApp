using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp.UtilityClasses;

public sealed class CommentGenerator
{
	public List<string>? PositiveComments { get; set; } = new List<string>();
	public List<string>? ExtremeComments { get; set; } = new List<string>();

	//Instantiate Randomiser Class
	public Randomiser Randomiser { get; set; } = new Randomiser();


	public CommentGenerator()
    {
		//Initialise Comments
		PositiveCommentsGenerator();
		ExtremeCommentsGenerator();	

	}

    public void PositiveCommentsGenerator()//Generate list of positive comments
    {
		foreach (var RandomNum in Randomiser.RandomNumberList1)
		{
			PositiveComments?.Add(RandomNum switch
			{
				1 => "NICE ONE!!..............",
				2 => "EXCELLENT!!.............",
				3 => "WOOOOOOOOO!!!!!...............YEAH!",
				4 => "BLOWING MY MIND!!!............",
				5 => "JUST IMPRESSIVE.........!!",
				6 => "NO FREAKING WAY!!!!...............",
				7 => "GOD LIKE!!................",
				8 => "AMAZING.....FIRE ON!!!!!",
				9 => "SUPERB!!!..............",
				10 => "JUST BRILLIANT!!!!!!!!!",
				11 => "WHO'S DIS GUY??!!!............",
				12 => "JUST WOW!!!!................",
				13 => "MAGNIFICENT!!!.............",
				14 => "OMG!!!!!!!!!!.............",
				15 => "SITTING ON TOP OF THE WORLD YEAH!!!!........",
				_ => "CHECK IT OOOOUUUTTT!!!!....."
			});
		}	

	}

	public void ExtremeCommentsGenerator()//Generate list of Extremely positive comments
	{
		foreach (var RandomNum in Randomiser.RandomNumberList1)
		{
			ExtremeComments?.Add(RandomNum switch
			{
				1 => "UNSTOPPABLE!!!!!!!!!!!!!",
				2 => "CLARK KENT!!!!!!!!!!!!!!",
				3 => "GODLIKE!!!!!!!!!!!!!!!!!",
				4 => "NA WAH OOOOOOOOOOOOOOOOO!!!!!!!",
				5 => "SUPER HUMAN!!!!!.........",
				6 => "SUPREME COMMANDER!!!!...............",
				7 => "MASTER OF THE UNIVERSE!!................",
				8 => "5 STARS!!!!!.........",
				9 => "GRIPPING!!!!!..............",
				10 => "FASTER THAN LIGHTNING!!!......",
				11 => "LEGENDARY!!!!!............",
				12 => "GO HARD!!!!................",
				13 => "FASTER THAN A SPEEDING BULLET!!!.............",
				14 => "OOOOOOO BOY!!!!!!!!!!.............",
				15 => "THERE IS GOD OOOOOOOOOO!!!!........",
				_ => "CHECK IT OOOOUUUTTT!!!!....."
			});
		}

	}

}
