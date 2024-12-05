using ArrayAnalyzer_Project;

Console.Write("please enter the num of Arrey : ");
int SizeOfArrey = int.Parse(Console.ReadLine());

int[] arrey = new int[SizeOfArrey];

for (int i = 0; i < SizeOfArrey; i++)
{
    Console.Write($"please enter the {i + 1} num of Arrey !");
    arrey[i] = int.Parse(Console.ReadLine());
}
int max = 0;
double average;
ArrayAnalyzerClass.AnalyzeArray(arrey, out average, ref max);
Console.WriteLine($"The max of Array you wrote is {max} , and average is {average:F1} .");
