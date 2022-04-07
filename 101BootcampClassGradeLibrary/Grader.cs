using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _101BootcampClassGradeLibrary
{
    public class Grader
    {

        public double CalculateAverage(List<double> inScores)
        {
            double _total = 0;
            foreach (var _score in inScores)
            {
                _total = _total + _score;
            }
            return _total / inScores.Count;
        }

    }
}
