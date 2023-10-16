using System.Globalization;

namespace DiceLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int userInput = GetDiceSides();

                int firstdiceValue = DiceValueFirst(userInput);
                int secondDiceValue = DiceValueSecond(userInput);

                int sumOfDice = DiceSum(firstdiceValue, secondDiceValue);

                DiceCombinations(userInput, firstdiceValue, secondDiceValue, sumOfDice);
                OtherDiceCombinations(userInput, sumOfDice);
                DiceCombinations12(userInput, firstdiceValue, secondDiceValue, sumOfDice);

                Console.WriteLine("Do you want to play again?");
                string yesOrNO = Console.ReadLine();
                string inputUpper = yesOrNO.ToUpper();


                if (inputUpper == "NO")
                {
                    return;

                }

            }

        }


        static int GetDiceSides()
        {
            Console.WriteLine("How many sides do your dice have?");
            while (true)
            {
                string usersNumberInput = Console.ReadLine();
                if (int.TryParse(usersNumberInput, out int numberOfSides) && numberOfSides >=1 )
                { 
                  return numberOfSides;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                
            }
        }



        static int DiceValueFirst(int firstInPut)
        {
            Random rng = new Random();
            int firstdiceValue = rng.Next(1, firstInPut);
              return firstdiceValue;
            
        }

        static int DiceValueSecond(int firstInPut)
        {
            Random rng = new Random();
            int secondDiceValue = rng.Next(1, firstInPut);
            return secondDiceValue;
        }






        static int DiceSum(int firstdiceValue, int secondDiceValue)
        {
            int sumOfDice = firstdiceValue + secondDiceValue;
            Console.WriteLine($"You got {firstdiceValue} and {secondDiceValue}. Your dice added up equal {sumOfDice}");
            return sumOfDice;
        }





        static void DiceCombinations(int firstInPut, int firstdiceValue, int secondDiceSides, int sumOfDice)
        {
            if (firstInPut == 6)
            {
                if (firstdiceValue == 1 && secondDiceSides == 1)
                {
                    Console.WriteLine("You got Snake Eyes!");
                }
                else if (firstdiceValue == 1 && secondDiceSides == 2 || firstdiceValue == 2 && secondDiceSides == 1)
                {
                    Console.WriteLine("You got Ace Deuce!");
                }
                else if (firstdiceValue == 6 && secondDiceSides == 6)
                {
                    Console.WriteLine("You got Box cars!");
                }
            }
        }

        static void OtherDiceCombinations(int firstInPut, int sumOfDice)
             {
                if (firstInPut == 6)
                {
                    if (sumOfDice == 7 && sumOfDice == 11 || sumOfDice == 11 && sumOfDice == 7)
                    {
                        Console.WriteLine("You Win!");
                    }
                    else if (sumOfDice == 2 || sumOfDice == 3 || sumOfDice == 12)
                    {
                        Console.WriteLine("You got craps.");
                    }
                }           
             }


        static void DiceCombinations12(int firstInPut, int firstdiceValue, int secondDiceSides, int sumOfDice)
        {
            if (firstInPut == 12)
            {
                if (firstdiceValue == 11 && secondDiceSides == 12)
                {
                    Console.WriteLine("Its a birthday!!");
                }
                else if (firstdiceValue == 8 && secondDiceSides == 4 || firstdiceValue == 4 && secondDiceSides == 8)
                {
                    Console.WriteLine("You got a box of rocks!");
                }
                else if (firstdiceValue == 1 && secondDiceSides == 12)
                {
                    Console.WriteLine("You got a spooky!");
                }
            }
        }







    }
}