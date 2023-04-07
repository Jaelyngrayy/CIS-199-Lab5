// Grading ID: R5560
// Lab 5
// Due Date: March 7, 2021
// Course Section: CIS 199-01
// Description: Program takes temperatures from the user and does so until a specific number is entered. The temps are then
// used to find the mean temperature and tells you how many temperatures you entered
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double average, //variable used to calculate average temp
                sum = 0, // used to add temps to each other
                tempNum = 0; //How many temperatures have been entered
            int temp; // Used to store the user inputted temp

            const int STOP = 999; // Constant variable used to stop the program

            //Asks user to enter temperature and input is stored in temp
            WriteLine("Enter temperatures from -20 to 130 (999 to stop)");
            Write("Enter temperature: ");
            temp = int.Parse(ReadLine());

            //While loop that occurs if the input does not equal 999
            while (temp != STOP)
            {
                if(temp >= -20 && temp <= 130) //happens if input is between a specific range
                {
                    sum += temp; //adds the temp to the sum variable
                    tempNum += 1; //adds 1 to the number of temps
                    Write("Enter temperature: "); //asks them to enter the temp again
                    temp = int.Parse(ReadLine());
                }
                else //occurs if temp entered is not in the range
                {
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
                    Write("Enter temperature: "); //asks them to enter another temp
                    temp = int.Parse(ReadLine());
                }
            }

            //occurs when the while loop is not occuring by entering 999
            average = sum / tempNum; //divides the sum by the number of temps to get the average temp
            WriteLine("");
            WriteLine("You entered {0} valid temperatues.", tempNum); //outputs number of temps
            WriteLine($"The mean temperature is {average:F1} degrees."); //outputs the average temp to one decimal point

        }
    }
}
