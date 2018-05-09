using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateService.Models
{
    public class Calculation
    {
        public double Mean { get; set; }
        public int Median { get; set; }
        public int Mode { get; set; }

        private List<int> _listToCalculate { get;}

        public Calculation(List<int> toCalculate)
        {
            Mean = -1;
            Median = -1;
            Mode = -1;

            _listToCalculate = toCalculate;
        }

        public Calculation()
        {
            Mean = -1;
            Median = -1;
            Mode = -1;

            _listToCalculate = null;

        }

        public void Calculate()
        {
            Mean = this.getMean();
            Median = this.getMedian();
            Mode = this.getMode();
        }



        private int getMedian()
        {
            int itemCount = _listToCalculate.Count();
            int half = itemCount / 2;

            var sorted = _listToCalculate.OrderBy(n => n);
            int median = -1;
            if(itemCount% 2 ==0)
            {
                median = ((sorted.ElementAt(half) + sorted.ElementAt(half - 1))) / 2;
            }
            else
            {
                median = sorted.ElementAt(half);
            }

            return median;
        }
        private double getMean()
        {
            return (int) _listToCalculate.Average();
        }

        private int getMode()
        {
            var mode = _listToCalculate.GroupBy(n => n)
                .OrderByDescending(m => m.Count()).Select(o => o.Key).FirstOrDefault();
            return mode;
        }
   
    }
}
