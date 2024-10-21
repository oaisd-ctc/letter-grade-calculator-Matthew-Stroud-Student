using System;

public class Program
{
    static double grade;
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade score.");
        string gradeString = Console.ReadLine();
        try
        {
            grade = double.Parse(gradeString);
            if (grade > 100)
            {
                Console.WriteLine("Holy moly.");
                Console.WriteLine("Letter Grade: A+");
            }
            else if (grade >= 93.5)
            {
                Console.WriteLine("Very nice!");
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 89.5)
            {
                Console.WriteLine("Very nice!");
                Console.WriteLine("Letter Grade: -A");
            }
            else if (grade >= 86.5)
            {
                Console.WriteLine("Keep it up!");
                Console.WriteLine("Letter Grade: +B");
            }
            else if (grade >= 83.5)
            {
                Console.WriteLine("Keep it up!");
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade >= 79.5)
            {
                Console.WriteLine("Keep it up!");
                Console.WriteLine("Letter Grade: -B");
            }
            else if (grade >= 76.5)
            {
                Console.WriteLine("You got this, keep working!");
                Console.WriteLine("Letter Grade: +C");
            }
            else if (grade >= 73.5)
            {
                Console.WriteLine("You got this, keep working!");
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade >= 69.5)
            {
                Console.WriteLine("You got this, keep working!");
                Console.WriteLine("Letter Grade: -C");
            }
            else if (grade >= 66.5)
            {
                Console.WriteLine("Keep trying!");
                Console.WriteLine("Letter Grade: +D");
            }
            else if (grade >= 63.5)
            {
                Console.WriteLine("Keep trying!");
                Console.WriteLine("Letter Grade: D");
            }
            else if (grade >= 59.5)
            {
                Console.WriteLine("Keep trying!");
                Console.WriteLine("Letter Grade: -D");
            }
            else
            {
                Console.WriteLine("are you even in this class LOL?!?");
                Console.WriteLine("Letter Grade: E");
            }
        }
        catch
        {
            Console.WriteLine("That aint a valid grade goofy.");
        }
    }
}