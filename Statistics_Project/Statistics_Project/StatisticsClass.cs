namespace Statistics_Project
{
    public class StatisticsClass
    {
        public static void AnalyzeNumbers(int A,ref int B,out int C)
        {
            Console.WriteLine($"the first value with out any Changes [{A}]");
            C = A + B;
            Console.WriteLine($"the sum of first[{A}] and second[{B}] num is [{C}]");
            Console.WriteLine($"[{B}]reached to the power of two is [{B*B}]");
        }
    }
}
