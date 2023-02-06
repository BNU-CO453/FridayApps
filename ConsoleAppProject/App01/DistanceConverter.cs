using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this 
    /// App here in a few lines.
    /// </summary>
    /// <author>
    /// Derek version 1.0
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280;
        public static double METERS_IN_MILE = 1609.34;

        private double miles, feet, meters;

        /// <summary>
        /// This method will output a heading for the
        /// application, a short description and then
        /// it will ask the user to enter a distance 
        /// in one unit and convert and output an 
        /// equivalent distance in another unit.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            OutputDescription();

            // Convert Miles to Feet

            InputMiles();
            CalculateFeet();
            OutputFeet();

            // Convert Feet to Miles

            InputFeet();
            CalculateMiles();
            OutputMiles();

            // Convert Miles to Meters

            InputMiles();
            CalculateMeters();
            OutputMeters();
        }

        private void InputMiles()
        {
            Console.WriteLine();
            Console.Write(" Please enter the distance in miles > ");
            
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// This method is so hort it does not
        /// need a comment.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILE;
        }

        private void OutputFeet()
        {
            Console.WriteLine();
            Console.WriteLine(" " + miles + " miles is " + feet + " feet");
            Console.WriteLine();
        }


        private void InputFeet()
        {
            Console.WriteLine();
            Console.Write(" Please enter the distance in feet > ");

            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILE;
        }

        private void OutputMiles()
        {
            Console.WriteLine();
            Console.WriteLine(" " + feet + " feet is " + miles + " miles");
            Console.WriteLine();
        }

        private void OutputMeters()
        {
            Console.WriteLine();
            Console.WriteLine(" " + miles + " miles is " + meters + " meters");
            Console.WriteLine();
        }

        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILE;
        }

        /// <summary>
        /// This method outputs a suitable heading for
        /// user to identify the application
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine("     ------------------------------");
            Console.WriteLine("        App01 Distance Converter");
            Console.WriteLine("            by Derek Peacock");
            Console.WriteLine("     ------------------------------");
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
