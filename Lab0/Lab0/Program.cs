using System;
using System.Collections.Immutable;
using System.IO;

namespace Lab0

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Variables
            Console.Write("Enter a low number: ");
            int Lowuservalue = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter a high number: ");
            int Highuservalue = Convert.ToInt16(Console.ReadLine());
            int differance = Highuservalue - Lowuservalue;
            Console.WriteLine(differance);
            //Task 2: Loops and input validation
            //since the assignment only specifies a low number and not what a
            //low number is i will assume a low number is less then 10 in this
            //example.
            bool loop = true;
            int userInput = 0;
            int userInput2 = 0;
            while (loop == true)
            {
                Console.Write("Enter a low number(less than 10): ");
                userInput = Convert.ToInt16(Console.ReadLine());
                if (userInput <= 10 && userInput >= 0)
                {
                    bool loop2 = true;
                    while (loop2 == true) //nested loop for the secound part of this section.
                    {
                        Console.Write("Please enter a number greater then your first number: ");
                        userInput2 = Convert.ToInt16(Console.ReadLine());
                        if (userInput < userInput2)
                        {
                            Console.WriteLine("Thats all thank you.");
                            loop = false;
                            loop2 = false;
                        }
                    }
                }
            }
            //Task 3: Arrays and File I/O
            int numsBetween = userInput2 - userInput - 1;
            int arrayValues = 0;
            int arrayIndex = 0;
            int[] nums = new int[numsBetween];
            int arrayAdd = userInput;
            while (arrayValues < numsBetween)
            {
                arrayAdd++;
                nums[arrayIndex] = arrayAdd;
                Console.WriteLine(nums[arrayIndex]);
                arrayIndex++;
                arrayValues++;
            }
            string path = @"C:\temp\numbers.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("exists");
            }
            Array.Reverse(nums);
            foreach (int i in nums)
            {
                string item = i.ToString();
                File.AppendAllText(path, item);
            }                
        }

    }
}
