using System;

class Program
{
    static void Main(string[] args)
    {

        // Console.Write("What is your grade percentage? ");
        // string userGrade = Console.ReadLine();

        // int grade = int.Parse(userGrade);

        //if (grade >= 90)
        //{
        //    Console.WriteLine("A");
        //}

        //else if (grade >= 80 && grade < 90)
        //{
        //    Console.WriteLine("B");
        //}

        //else if (grade >= 70 && grade < 80)
        //{
        //   Console.WriteLine("C");
        //}

        //else if (grade >= 60 && grade < 70)
        //{
        //   Console.WriteLine("D");
        //}

        //else
        //{
        //    Console.WriteLine("F");

        //}


        //if (grade >= 70)
        //{
        //    Console.WriteLine("Course passed, Well Done!");
        //}

        //else
        // {
        //     Console.WriteLine("Course failed, try again.");
        // }

        Console.WriteLine("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");
    }
}