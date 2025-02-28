﻿using System;
using System.Linq;

namespace Calc.Utilities
{
    public class Input
    {
        public static int AskForIntInput(int minValue, int maxValue, string recurringLine)
        {
            int inputValue;
            string warningMessage = "Invalid Choice! Enter a Number between " + minValue + " and " + maxValue + ".";
            Output.PrintTextInColor(recurringLine, ConsoleColor.Green, false);

            while (!int.TryParse(Console.ReadLine(), out inputValue) || inputValue < minValue || inputValue > maxValue)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 2);
                Output.PrintTextInColor(warningMessage, ConsoleColor.Red, true);
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
                Output.PrintTextInColor(recurringLine, ConsoleColor.Green, false);
            }
            Output.RemoveLastPrintedLine();
            Output.RemoveLastPrintedLine();
            Console.WriteLine("");
            return inputValue;
        }
        public static double[] ParseDoubleInput(string userInput)
        {
            return userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        }
        public static void WaitForSpacebar()
        {
            string printedMessage = "Press <Spacebar> to Return to Main Menu... ";
            Console.WriteLine("");
            Output.PrintTextInColor(printedMessage, ConsoleColor.Green, true);
            while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
        }
    }
}
