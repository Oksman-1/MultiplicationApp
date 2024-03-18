using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationApp.UtilityClasses;

public static class TimeFactor
{
	//Create Result property
	public static double Result { get; set; } = 0.0;

	
	public static double Factor(int score, List<int> loopCount, long elapsedTime)
	{
		if (loopCount.Count > 0 && elapsedTime > 0)
		{
			//Raw Score as a quotient
			double quotient = (double)score / loopCount.Count;
			double factor = 0.0;

			//Generate Time factor
			if (elapsedTime <= 30000)
			{
				factor = 1.0;
			}
			else if (elapsedTime >= 30001 && elapsedTime <= 35000)
			{
				factor = 0.8;
			}
			else if (elapsedTime >= 35001 && elapsedTime <= 40000)
			{
				factor = 0.6;
			}
			else if (elapsedTime >= 40001) 
			{
				factor = 0.2;
			}

			//Get Time-Dependent score as a percentage
			Result = quotient * factor * 100;			
		}
		else
		{
			throw new Exception("LoopCount or Elapsed Time cannot be Negative!");			
		}

		return Result;
	}
}
