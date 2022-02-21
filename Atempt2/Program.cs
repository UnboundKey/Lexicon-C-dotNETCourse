using System;
using System.Collections.Generic;
using System.IO;

namespace Atempt2
{
    class Program
    {
        static string[] programs = { "Exit", "Hello World", "Name and Age repeater", "Change Text Color", "Todays Date", "Compare Numbers", "Number Guessing Game", "Write Message to File", "Read Message from File", "Square root, Power of 2 and 10", "Multiplication Table","Array Storer", "Palindrome","Numbers Inbetween", "CSV odds and evens"};

        static string fileName = "WrittenFile";
        static string filePath = Environment.CurrentDirectory + "\\" + fileName;

        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Write a number to pick a program");
                for (int i = 0; i < programs.Length; i++)
                {
                    Console.WriteLine(i + ") " + programs[i]);
                }
                string conInput = Console.ReadLine();
                // makes sure input is a number, if not it defaults to one past the max programs triggering the default response;
                int conParsedInput = Helper.ParseInt(conInput, programs.Length + 1);

                switch (conParsedInput)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        helloWorld();
                        break;
                    case 2:
                        firstLastNameAge();
                        break;
                    case 3:
                        conColorChanger();
                        break;
                    case 4:
                        writeTodaysDate();
                        break;
                    case 5:
                        numberCompare();
                        break;
                    case 6:
                        numberGuesser();
                        break;
                    case 7:
                        writeToDisk();
                        break;
                    case 8:
                        readFromDisk();
                        break;
                    case 9:
                        squareRoutePower();
                        break;
                    case 10:
                        mulTable(10,10);
                        break;
                    case 11:
                        arraySorter();
                        break;
                    case 12:
                        palindromeChecker();
                        break;
                    case 13:
                        numbersInbetween();
                        break;
                    case 14:
                        csvEvenOrOdd();
                        break;
                    default:
                        Console.WriteLine("The program you are trying to run cannot be found");
                        break;
                }
            }

        }

        private static void helloWorld()
        {
            Console.WriteLine("Hello World");
        }
        private static void firstLastNameAge()
        {
            string firstName = Helper.conWriteLineRead("What is your first name?: ");
            string lastName = Helper.conWriteLineRead("What is your last name?: ");
            int age = Helper.ParseInt(Helper.conWriteLineRead("What is your age?: "));
            Console.WriteLine(string.Format("Hello {0} {1}, you are {2} years old", firstName, lastName, age));

        }
        private static void conColorChanger()
        {
            ConsoleColor newColor = ConsoleColor.Green;
            if (Console.ForegroundColor != newColor)
            {
                Console.ForegroundColor = newColor;
            } else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        private static void writeTodaysDate()
        {
            Console.WriteLine(DateTime.Today.Date.ToString("d"));
        }
        private static void numberCompare()
        {
            float number1 = Helper.ParseFloat(Helper.conWriteLineRead("What is your first number?: "));
            float number2 = Helper.ParseFloat(Helper.conWriteLineRead("What is your Second number?: "));

            if (number1 > number2)
            {
                Console.WriteLine(string.Format("{0} is bigger than {1}", number1, number2));
            } else if (number1 < number2) {
                Console.WriteLine(string.Format("{1} is bigger than {0}", number1, number2));
            } else
            {
                Console.WriteLine(string.Format("{0} is the same size as {1}", number1, number2));
            }
        }
        private static void numberGuesser()
        {
            Random r = new Random();
            int goalNumber = r.Next(1, 100);
            int guessedNumber = 0;
            int numOfGuesses = 0;
            Console.WriteLine("I've picked a number, try to guess it please.");

            while (guessedNumber != goalNumber)
            {
                guessedNumber = Helper.ParseInt(Console.ReadLine());
                numOfGuesses++;
                if (guessedNumber < goalNumber)
                {
                    Console.WriteLine("Go a little HIGHER");
                } else if (guessedNumber > goalNumber)
                {
                    Console.WriteLine("Go a little LOWER");
                }
            }
            Console.WriteLine(string.Format("You guessed right in {0} guesses good job", numOfGuesses));
        }
        private static void writeToDisk()
        {

            string writeInput = Helper.conWriteLineRead("What do you want to write to file: ");
            File.WriteAllText(filePath, writeInput);
        }
        private static void readFromDisk()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine(File.ReadAllText(filePath));
            } else
            {
                Console.WriteLine("Cannot find file at: " + filePath + " please make sure that the file exists");
            }
        }
        private static void squareRoutePower()
        {
            float inputFloat = Helper.ParseFloat(Helper.conWriteLineRead("Write a decimal number: "));
            Console.WriteLine(string.Format("Square Root: {0}, To the power of 2: {1}, To the power of 10: {2}", Math.Sqrt(inputFloat),Math.Pow(inputFloat,2), Math.Pow(inputFloat, 10)));
            
        }
        private static void mulTable(int heightCollumns, int widthCollumns)
        {
            for(int x = 0; x < heightCollumns; x++)
            {
                for (int y = 0; y < widthCollumns; y++)
                {
                    Console.Write((y+1) * (x+1) + "  ");
                }
                Console.WriteLine();
            }
        }
        private static void arraySorter()
        {
            int[] randomArray;
            int[] sortedArray;
            //amount of random Numbers to be generated
            int maxRandomNums = 10;
            // the maximum number the RNG can reach
            int randomGenCeiling = 100;
            randomArray = new int[maxRandomNums];
            sortedArray = new int[maxRandomNums];
            int tempStorage;

            Random r = new Random();
            // Filling the array with 10 random numbers from 1 to 100
            Console.WriteLine("----------------");
            for (int i = 0; i < maxRandomNums; i ++)
            {
                randomArray[i] = r.Next(1,randomGenCeiling);
                //Copying values from random array to sorted array
                sortedArray[i] = randomArray[i];
                //printing out generated numbers
                Console.WriteLine(randomArray[i]);
            }
            
            Console.WriteLine("----------------");
            //loops through all values, checks which one is bigger, then swaps them so that the bigger value moves closer to the end or the array
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for(int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[i] > sortedArray[j])
                    {
                        //Console.WriteLine(string.Format("i:{0} j:{1} i value: {2} j value: {3}", i, j, randomArray[i], randomArray[j]));
                        tempStorage = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = tempStorage;
                    }

                }
                
            }
            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.Write(sortedArray[i] + "\t");
            }
           
        }
        private static void palindromeChecker()
        {
            string input = Helper.conWriteLineRead("Enter a string to see if it's a palindrome:");
            string flippedInput = Helper.StringFlipper(input);
            if(string.Compare(input,flippedInput) == 0)
            {
                Console.WriteLine(string.Format("{0} is a palindrome", input));
            } else
            {
                Console.WriteLine(string.Format("{0} is not a palindrome", input));
            }

        }
        private static void numbersInbetween()
        {
            Console.WriteLine("Please write two numbers and we'll display all the numbers inbetween");
            
            string firstNumberInput = Helper.conWriteRead("What is your first number?: ");
            string secondNumberInput = Helper.conWriteRead("What is your second number?: ");
            int firstNumber = Helper.ParseInt(firstNumberInput);
            int secondNumber = Helper.ParseInt(secondNumberInput);

            for (int i = firstNumber; i < secondNumber + 1; i ++)
            {
                Console.WriteLine(i);
            }
        }

        private static void csvEvenOrOdd()
        {
            // This function gets input from the user, puts them into odd or even categorys and sorts them in size order, then outputs it to the user.
            string input = Helper.conWriteLineRead("write some numbers separated with a \",\"");
            string[] inputArray = input.Split(",");

            List<int> odds = new List<int>();
            List<int> evens = new List<int>();
            // loop through all inputed numbers and add them to the corresponding list of ints for odds or evens
            for (int i = 0; i < inputArray.Length; i++)
            {
                //Console.WriteLine(inputArray[i]);
                int currentNumber = Helper.ParseInt(inputArray[i]);
                // If the number can be evenly devided by 2 then put it in the evens list, else put it in the odds.
                if (currentNumber % 2 == 0)
                {
                    evens.Add(currentNumber);
                }
                else
                {
                    odds.Add(currentNumber);
                }
            }
            //sort the list with a helper function.
            odds = Helper.SortList(odds);
            evens = Helper.SortList(evens);

            //loop through the lists and output all the numbers
            Console.WriteLine("-ODDS-");
            foreach (var item in odds)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-EVENS-");
            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }
        }
    }

}
