using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 1.0
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280;

        private double miles, feet;

        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        private void InputMiles()
        {
            Console.WriteLine();
            Console.Write(" Please enter the distance in miles > ");
            
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILE;
        }

        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine(" The number of feet is " + feet.ToString());
            Console.WriteLine();
        }

        /// <summary>
        /// This method outputs a suitable heading for
        /// user to identify the application
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine(" ------------------------------");
            Console.WriteLine("    App01 Distance Converter");
            Console.WriteLine("        by Derek Peacock");
            Console.WriteLine(" ------------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// This method will output a short description
        /// of what the application does.
        /// </summary>
        private void OutputDescription()
        {
            Console.WriteLine(
                " This application will convert a distance\n" +
                " entered in miles to the same distance\n" +
                " measured in feet");
            
            Console.WriteLine();
        }
    }
}
