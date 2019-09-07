using System;
using System.Diagnostics;

namespace assignmentOne
{
    /*
     * Structure of C# program
     * using System;
     * namespace YourNamespace
     * {
     * 
     * class YourClass
     * {
     * }
     * 
     * struct YourStruct
     * {
     * }
     * 
     * interface YourInterface
     * {
     * }
     * 
     * delegate int YourDelegate();
     * 
     * enum YourEnum
     * {
     * }
     * 
     * class YourMainClass
     *      static void Main(string[] args)
     *      {
     *      }
     *}
     *}
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize.
            string p;
            int x;
            int y;
            int d1;
            int d2;
            int j;
            bool selfDividing;

            //Pseudocode
            p = "This is pseudocode. Initialize a variable selfDividing=true\n";
            p = p + "Read first number in the series of x to y in increments of 1. Lets say it is N1\n";
            p = p + "Find Modulo 10 of first number. It will give the unit place digit as reminder. Lets say it is D1\n";
            p = p + "If unit digit is zero, go to next step break the loop and iterate next number. If unit digit is > 0, do a modulo division of N1 by D1. If result is 0, it divides perfectly. If result is >0, break this inner loop and iterate next number\n";
            p = p + "Do a regular division of first number N1 by 10. If result is < 0, print 'N1 is self dividing'. If result is > 0, repeat previous two steps\n";
            Debug.WriteLine("Assignment 1. Self Dividing Number");
            Debug.WriteLine(p);

            //Read input
            //x = 100;
            //y = 125;
            Debug.WriteLine("Enter value for first number x:");
            x = int.Parse(Console.ReadLine());
            Debug.WriteLine("Enter value for second number y:");
            y = int.Parse(Console.ReadLine());

            //Iterate
            for (int i=x; i<y+1; i++) //For each number in the given range of x to y
            {
                selfDividing = true; //Start with a optimistic judgement, this number is selfDividing
                j = i;
                while (j > 0) //Use a different variable 'j' to get each digit in the given number
                {
                    d1 = j % 10; //Find the unit digit of the number. At end of whileloop, j is trimmed of this unit digit to make new j
                    if (d1 == 0) //If unit digit is zero, then this number is not self dividing
                    {
                        selfDividing = false;
                        break;
                    }
                    else
                    {
                        d2 = i % d1; //If unit digit is not zero, then divide the input number x by the unit digit
                        if (d2 > 0) // If it does not perfectly divide, there is a reaminder, this is not self dividing number
                        {
                            selfDividing = false;
                            break;
                        }
                        else
                        {
                            //continue;
                            //selfDividing = true;
                        }
                    }
                    j = j / 10; //Trim the j to cast away the last digit on right and retain the remaining digits on left to repeat the steps above in the while loop
                }
                if (selfDividing==true)
                {
                    Debug.WriteLine($"{i} is self dividing", i);
                }
                else
                {
                    //Debug.WriteLine($"{i} is not self dividing", i);
                }
            }
        }
    }
}
