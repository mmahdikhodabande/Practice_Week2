using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAnalyzer_Project
{
    public class ArrayAnalyzerClass
    {
        public static void AnalyzeArray(int[] Array,out double Avg, ref int Max)
        {
            double res = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Max)
                {
                    Max = Array[i];
                }
                res += Array[i];
                
            }
            Avg = res/Array.Length;
        }
    }
}
