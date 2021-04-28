using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Validate
    {

        public double GetMin(double firstNo, double secondNo, double thirdNo)
        {
            List<double> numbersList = new List<double>();
            numbersList.Add(firstNo);
            numbersList.Add(secondNo);
            numbersList.Add(thirdNo);


            var min = numbersList[0];

            for (int i = 1; i < numbersList.Count; i++)
            {
                if (min > numbersList[i])
                {
                    min = numbersList[i];
                }
            }
            return min;
        }

        public double GetMax(double firstNo, double secondNo, double thirdNo)
        {
            List<double> numbersList = new List<double>();
            numbersList.Add(firstNo);
            numbersList.Add(secondNo);
            numbersList.Add(thirdNo);


            var max = numbersList[0];

            for (int i = 1; i < numbersList.Count; i++)
            {
                if (max < numbersList[i])
                {
                    max = numbersList[i];
                }
            }
            return max;
        }
    }
}
