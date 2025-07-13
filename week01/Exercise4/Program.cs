using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                num.Add(input);
            }
        }
        while (input != 0);
        {
            int sum = 0;
            foreach (int n in num)
            {
                sum += n;
            }
            Console.WriteLine($"The sum is: {sum}");

            float average = (float)sum / (float)num.Count;
            Console.WriteLine($"The average is: {average}");

            int max = num[0];
            foreach (int n in num)
            {
                if (n > max)
                {
                    max = n;
                }

            }
        Console.WriteLine($"The max is: {max}");
        }

        


        
    }
}