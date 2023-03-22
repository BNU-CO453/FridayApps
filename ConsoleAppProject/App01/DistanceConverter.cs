﻿using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public static double FEET_IN_MILE = 5280;
        public static double METER_IN_MILE = 1609.34;

        private double miles, meters, feet;

        public void Run()
        {
            OutputHeading();

            InputMiles();
            CalculateFeet();
            OutputFeet();

            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        private void OutputMiles()
        {
            throw new NotImplementedException();
        }

        private void CalculateMiles()
        {
            throw new NotImplementedException();
        }

        private void InputFeet()
        {
            throw new NotImplementedException();
        }

        private void OutputFeet()
        {
            throw new NotImplementedException();
        }

        private void CalculateFeet()
        {
            throw new NotImplementedException();
        }

        private void InputMiles()
        {
            throw new NotImplementedException();
        }

        private void OutputHeading()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("   App01 Distance Converter");
            Console.WriteLine("-----------------------------");
        }
    }
}
