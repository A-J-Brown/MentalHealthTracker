using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalHealthTracket.Shared.Services.Interfaces
{
    interface IHealthCalculator
    {
        int MoodAverage(int[] moods);
    }
}
