using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloWorld
{
    class Program
    {
        //Function will return an int value
        static double more(double i, double j)
        {
            double ret;
            ret = ((i * j) + 7) / 3;
            return ret;
        }

        static string palaTest(char[] word)
        {
            string ret="";

            for(int i=0; i<word.Length; i++)
            {
                if(word[i] != word[(word.Length) - (i+1)])
                {
                    ret = " is not a palindrome.";
                    break;
                }
                else
                {
                    ret = " is a palindrome.";
                }
            }
            return ret;
        }

        static void sortArr(int[] arr)
        {            //Check each number from the start of the array. 
            for (int i = 0; i < arr.Length; i++)
            {
                //Compare number i’s number to j’s number. 
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int Selected = arr[i];
                    int Check = arr[j];

                    //If i’s number is greater than j’s swap the two numbers in the  
                    //array.  And continue comparing all the numbers in the array. 
                    //If i’s number is less than j’s number leave the two numbers alone. 
                    //This method is called Selection Sort. 
                    if (Selected > Check)
                    {
                        arr[i] = Check;
                        arr[j] = Selected;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != 4)
                    Write(arr[i] + ", ");
                else
                    Write(arr[i] + "\n");
            }
        }

                static void Main(string[] args) {
            //This is the set of variables that I am using in this program
            double a, b, c;
            string useIn, pTest, result;
            int[] testArr = new int [5];
            char[] palindrome;

            a = 3;
            b = a * 6;
            //Calls the more method using two variables
            c = more(a, b);

            for (int i=0; i<3; i++)
            {
                testArr[i] = (i*5)+3;
            }

            testArr[3] = 2;
            testArr[4] = 1;
            
            //Simple Hello World
            WriteLine("Hello World");
            //
            WriteLine("Returning from 'more' funtion method: " + c);

            //Prompt the user to enter a string
            WriteLine("\nEnter in a string:");
            //Have the user input a string to be stored in the string useIn
            useIn = Console.ReadLine();
            //Write out the results
            WriteLine("\nYou entered in: " + useIn);
            //Testing printing an array with if else statements
            WriteLine("\nTesting a For Loop, and If/Else statements with an Array: ");
            for (int i = 0; i < 5; i++)
            {
                if (i != 4)
                    Write(testArr[i] + ", ");
                else
                    Write(testArr[i] + "\n");
            }
            WriteLine("\nWe need to sort this array in order now: ");
            sortArr(testArr);
            

            //Prompt the user to enter a string
            WriteLine("\nEnter in a word to be tested as a palindrome:");
            //Have the user input a string to be stored in the char Array palindrome
            pTest = Console.ReadLine();
            //convert string to all lower case for better checking
            palindrome = pTest.ToLower().ToCharArray();

            result = palaTest(palindrome);
            WriteLine("Your word " + pTest + result);

            //Waits till user to hit any key before prompting them to exit.
            Console.ReadKey(true);
        }
    }
}
