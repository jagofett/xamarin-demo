using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TourStops.Utilities
{
	public class Duration
	{
		private const int TimePerStop = 45; // minutes
		public double CalculateTourDuration(int numberOfStops, double speedRatio)
		{
			// some code for debugging demo

			var temp = numberOfStops + 5;
			var duration = (numberOfStops * TimePerStop) * speedRatio;
			return duration;
		}
	}
}