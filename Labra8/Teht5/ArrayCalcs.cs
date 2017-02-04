using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht5
{
    interface IArrayCalcs
    {
        double sum(double[] array);
        double ave(double[] array);
        double max(double[] array);
        double min(double[] array);
    }
    public class ArrayCalcs : IArrayCalcs
    {

        double result;
        public double sum(double[] array)
        {
            foreach (double d in array)
            {
                result += d;
            }
            return result;
        }
        public double ave(double[] array)
        {
            if (result == 0) { return 0; }
            else return result/array.Length;
        }
        public double max(double[] array)
        {
            if (array.Length == 0) { return 0; }
           else return array.Max();
        }
        public double min(double[] array)
        {
            if (array.Length == 0) { return 0; }
            else return array.Min();
        }
    }
}
