using System;

namespace Problem_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalForTheDay = int.Parse(Console.ReadLine());
            int incoming = 0;
            string haircutType = Console.ReadLine();

            while (haircutType != "closed")
            {
                string type = Console.ReadLine();
                switch (haircutType)
                {
                    case "haircut":
                        switch (type)
                        {
                            case "mens":
                                incoming += 15;
                                break;
                            case "ladies":
                                incoming += 20;
                                break;
                            case "kids":
                                incoming += 10;
                                break;
                        }
                        break;
                    case "color":
                        switch (type)
                        {
                            case "touch up":
                                incoming += 20;
                                break;
                            case "full color":
                                incoming += 30;
                                break;
                        }
                        break;
                }
                
                if (incoming >= goalForTheDay)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {incoming}lv.");
                    break;
                }
                haircutType = Console.ReadLine();
            }
            if (incoming < goalForTheDay)
            {
                Console.WriteLine($"Target not reached! You need {goalForTheDay - incoming}lv. more.");
                Console.WriteLine($"Earned money: {incoming}lv.");
            }
        }
    }
}
