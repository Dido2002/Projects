using System;
using System.Linq;

namespace exercicesss02
{
    internal class Program
    {
        static double initialLev = 1000;
        static double initialEuro = 1000;
        static int commisionPercent = 1;
        static double coursLev = 0.99;
        static double coursEuro = 1.95;
        static void Main(string[] args)
        {
            CalculateMoneyForTheDay(3);
        }
        static void CalculateMoneyForTheDay(int transactionCount)
        {
            double[] levTransactions = new double[transactionCount];
            double[] euroTransactions = new double[transactionCount];
            for (int i = 0; i < transactionCount; i++)
            {
                Console.WriteLine("What transaction do you wanna do?");
                Console.WriteLine("Options: ");
                Console.WriteLine("1. Euro -> Lev");
                Console.WriteLine("2. Lev -> Euro");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    euroTransactions[i] = MakeEuroTransaction();
                }
                else if (answer == 2)
                {
                    levTransactions[i] = MakeLevTransaction();
                }
            }
            CalculateEndOfDaySum();
            Console.WriteLine($"Max euro:{euroTransactions.Max()}");
            Console.WriteLine($"Max lev:{levTransactions.Max()}");


        }
        static double MakeEuroTransaction()
        {
            Console.WriteLine("Enter sum in euro:");
            double sum = double.Parse(Console.ReadLine());
            double sumInLv = sum * coursEuro;
            double currentCommision = sumInLv * 0.01;
            initialLev += currentCommision;

            initialEuro += sum;
            initialLev -= sumInLv - currentCommision;
            return sum;

        }
        static double MakeLevTransaction()
        {
            Console.WriteLine("Enter sum in lev: ");
            double sum = double.Parse(Console.ReadLine());
            double sumInEuro = sum * coursLev;
            double currentCommision = sumInEuro * 0.01;
            initialEuro += currentCommision;
            initialLev += sum;
            initialEuro -= sumInEuro - currentCommision;
            return sum;


        }
        static void CalculateEndOfDaySum() 
        
        {
             double sumInLev = initialLev + (initialEuro * coursEuro);
            double sumInEuro = initialEuro + (initialLev * coursLev);
            Console.WriteLine($"End of the day sum in lev: {sumInLev}");
            Console.WriteLine($"End of the day sum in euro: {sumInEuro}");
        
        
        }

    }

}
