using System;

namespace exercicesss03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of names");
            int n = int.Parse(Console.ReadLine());  
            string[] firstNames = new string[n];
            string[] secondNames = new string[n];
            FillNames(firstNames, secondNames);
            PrintArray(firstNames);
            PrintArray(secondNames);
            Console.WriteLine($"Average first name{CalculateAverageNameSize(firstNames)}");
            Console.WriteLine($"Average second name{CalculateAverageNameSize(secondNames)}");
            Console.WriteLine($"Enter name to searche: ");
            string searchedName = Console.ReadLine();
            Console.WriteLine($"First names that match: {CountNames(firstNames, searchedName)}");
            Console.WriteLine($"Last names that match: {CountNames(secondNames, searchedName)}");
            Console.WriteLine("Enter s substring you searche for!");
            string sub = Console.ReadLine();
            FindSubstring(firstNames, sub);
            FindSubstring(secondNames, sub);
            FindLongestName(firstNames);
            FindShortestName(secondNames);
            ReplaceLetter(firstNames, 'a', '*');
            ReplaceLetter(secondNames, 'v', '$');
            PrintArray(firstNames);
            PrintArray(secondNames);



        }
        static void FillNames(string[] firstNames, string[] secondNames) 
        {
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine("Rnter first and last name: ");
                string names = Console.ReadLine();  
                string[] result = names.Split(' ');   
                firstNames[i] = result[0];
                secondNames[i] = result[1];   
            }
        }
        static void PrintArray(string[] items) 
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"Name: {i + 1}, {items[i]}");
            }
        }
        static double CalculateAverageNameSize(string[] names) 
        {
             double sum = 0;
            for (int i = 0; i < names.Length; i++) 
            {
              sum += names[i].Length;  
            
            }
            return sum/ names.Length;   
             

        }
        static int CountNames(string[] names, string searchedName) 
        {
            int counter = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == searchedName)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void FindSubstring(string[] names, string substring) 
        {
            Console.WriteLine($"A list of names that contain {substring}");
            foreach (string name in names)
            {
                if (name.Contains(substring)) 
                {
                    Console.WriteLine(name);
                }
            }
        }
        static void FindLongestName(string[] names) 
        {
         int longestNameIndex = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > names[longestNameIndex].Length) 
                {
                    longestNameIndex = i;
                }
            }
            Console.WriteLine($"The longest names is: {names[longestNameIndex]}, with characters: {names[longestNameIndex].Length}");

        }
        static void FindShortestName(string[] names) 
        {
            int shortestNameIndex = 0;
            for (int i = 0; i < names.Length; i++) 
            {
                if (names[i].Length < names[shortestNameIndex].Length) 
                {
                   shortestNameIndex = i;  
                }  
            }
            Console.WriteLine($"The shortest name is: {names[shortestNameIndex]}, with characters: {names[shortestNameIndex].Length}");
        
        }
        static void CheckForLetter(string[] names, char startingLetter) 
        {
            Console.WriteLine($"A list of letters starts with the letter: {startingLetter}");
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].StartsWith(startingLetter))
                    Console.WriteLine(names[i]);
                
                
            }
        
        }
        static void ReplaceLetter(string[] names, char letterToReplace, char replaceSymbol) 
        {
            for (int i = 0; i < names.Length; i++)
            {
                string currentName = names[i];
                string replacedName = currentName.Replace(letterToReplace, replaceSymbol);
                names[i] = replacedName;
     
            }
        }
    }
}
