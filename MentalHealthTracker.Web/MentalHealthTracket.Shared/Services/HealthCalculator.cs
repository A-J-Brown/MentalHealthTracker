using MentalHealthTracket.Shared.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealthTracket.Shared.Services
{
   public class HealthCalculator : IHealthCalculator

    {
        public int MoodAverage(int[] moods)
        {
            var average = moods.Average();
            return (int)Math.Round(average, 0);
        }
    }
}
