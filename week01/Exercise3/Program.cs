using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNum = int.Parse(Console.ReadLine());

        Random randonGenerator = new Random();
        int magicNum = randonGenerator.Next(1, 101);

        int guess = -1;
        do
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
        }

        while (guess != magicNum);

        Console.WriteLine("You guessed it!");
        
        
        


    }
}