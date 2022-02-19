using System;
using System.Collections.Generic;
using System.Text;

namespace Atempt2
{
    class Helper
    {
        /// <summary>
        /// This string will print to the console and then return the input from the user as a string
        /// </summary>
        /// <param name="printString"></param>
        /// <returns></returns>
        public static string conWriteLineRead(string printString)
        {
            Console.WriteLine(printString);
            return Console.ReadLine();
        }
        public static string conWriteRead(string printString)
        {
            Console.Write(printString);
            return Console.ReadLine();
        }
        /// <summary>
        /// This will try to parse an int from the passed in string, if it failes it will print an error message to console, and return a 0 as a fallback value
        /// </summary>
        /// <param name="ParseString"></param>
        /// <returns></returns>
        public static int ParseInt(string ParseString)
        {
            int conSelection = 0;
            try
            {
                conSelection = int.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        /// <summary>
        /// This will try to parse an int from the passed in string and if it fails print an error message, and return the fallback value specified
        /// </summary>
        /// <param name="ParseString"></param>
        /// <param name="FallbackValue"></param>
        /// <returns></returns>
        public static int ParseInt(string ParseString, int FallbackValue)
        {
            int conSelection = FallbackValue;
            try
            {
                conSelection = int.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        public static int ParseInt(string ParseString, string ErrorMessage)
        {
            int conSelection = 0;
            try
            {
                conSelection = int.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(ErrorMessage);
            }
            return conSelection;
        }

        public static float ParseFloat(string ParseString)
        {
            float conSelection = 0;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        public static float ParseFloat(string ParseString, float FallbackValue)
        {
            float conSelection = FallbackValue;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine("Cannot parse input string, please use numbers");
            }
            return conSelection;
        }

        public static float ParseFloat(string ParseString, string ErrorMessage)
        {
            float conSelection = 0;
            try
            {
                conSelection = float.Parse(ParseString);
            }
            catch
            {
                Console.WriteLine(ErrorMessage);
            }
            return conSelection;
        }

        public static string StringFlipper(string Input)
        {
            string reversedInput = "";
            for(int i = Input.Length; i > 0; i--)
            {
                reversedInput = reversedInput + Input[i-1];
            }
            return reversedInput;
        }

        public static int[] SortArray(int[] unsortedIntArray)
        {
            int[] sortedInts = new int[unsortedIntArray.Length];
            int tempStorage;
            for (int i = 0; i < unsortedIntArray.Length; i++)
            {
                sortedInts[i] = unsortedIntArray[i];
            }

            for (int i = 0; i < sortedInts.Length; i++)
            {
                for (int j = i + 1; j < sortedInts.Length; j++)
                {
                    if (sortedInts[i] > sortedInts[j])
                    {
                        //Console.WriteLine(string.Format("i:{0} j:{1} i value: {2} j value: {3}", i, j, randomArray[i], randomArray[j]));
                        tempStorage = sortedInts[i];
                        sortedInts[i] = sortedInts[j];
                        sortedInts[j] = tempStorage;
                    }

                }

            }

            return sortedInts;
        }
    }
}
