using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            string go;
            string Yes = " ";
           
            Console.WriteLine("Welcome to Batting Average Calculator!");
            //Console.WriteLine("Continue Calculate? \n Enter 'yes' or 'no'");
            //go = Console.ReadLine();
        
            //string Yes = go.ToUpper();


            do
            {
                Console.WriteLine("Enter number of times at bat:");
                int numberOfTimesAtBat = int.Parse(Console.ReadLine());
                int[] numberOfTimesBated = new int[numberOfTimesAtBat];

                try
                {
                    Console.WriteLine("enter Results for at-bat {0}", numberOfTimesBated.Length);

                    for (int i = 0; i < numberOfTimesAtBat; i++)
                    {
                        Console.Write("Result for at-bat " + (i + 1) + ": ");

                        int numberOfBases = int.Parse(Console.ReadLine());
                        if (numberOfBases == 0 || numberOfBases == 1 || numberOfBases == 2 || numberOfBases == 3 || numberOfBases == 4)
                        {
                            numberOfTimesBated[i] = numberOfBases;
                        }

                        else
                            throw new Exception();
                    }

                    double average = calculateBattingAverage(numberOfTimesBated);

                    Console.WriteLine("\n\nThe Average score for the batter is: \t" + average);

                    double sluggingAverage = calculateSluggingAverage(numberOfTimesBated);
                    Console.WriteLine("The Slugging Average for the batter is: \t" + sluggingAverage);

                   
                }
                catch

                {
                    Console.WriteLine("oops! Base ball has maximum of 4 bases!");
                    Console.WriteLine("Try again!");
                    Console.WriteLine("Do you still want to Continue? (y/n)");
                    go = Console.ReadLine();
                }

            } while (Yes == "YES" || Yes == "Y");

            Console.WriteLine("\n\nAnother batter? (y/n)");
            go = Console.ReadLine().ToUpper();
            if (go == "Y")
                Yes = go;
            else
                Console.WriteLine("Thank you for your time");
            Console.ReadLine();
        }
            
        
    
      public static double calculateBattingAverage(int[] battingSheet)
        {
            int numerOfHits = 0;
            for (int i = 0; i < battingSheet.Length; i++)
            {
                if (battingSheet[i] != 0)
                {
                    numerOfHits++;
                }

            }
            // Console.WriteLine(numerOfHits);
            //Console.WriteLine(battingSheet.Length);
            return (double)numerOfHits / battingSheet.Length;
        }

        public static double calculateSluggingAverage(int[] battingSheet)
        {
            int numerOfHits = 0;
            for (int i = 0; i < battingSheet.Length; i++)
            {
                if (battingSheet[i] != 0)
                {
                    numerOfHits = numerOfHits + battingSheet[i];
                }

            }
            // Console.WriteLine(numerOfHits);
            //Console.WriteLine(battingSheet.Length);
            return (double)numerOfHits / battingSheet.Length;
        }
    }
}





