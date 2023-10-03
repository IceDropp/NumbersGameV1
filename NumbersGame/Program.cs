namespace NumbersGame
{
    internal class Program
    {
        static void Main()
        {
            int randomNumber = GenerateRandomNumber();
            int guessedNumber = GetGuesedNumber();
            NumberCheck(guessedNumber, randomNumber);
            Console.ReadLine();
        }
        static int GetGuesedNumber()
        {
            Console.WriteLine("Välkommen jag tänker på ett nummer kan du gissa vilket? Du får fem försök");

            int guessedNumber = 1; /*
            if (!int.TryParse(Console.ReadLine(), out guessedNumber)) //skräp
            {
                Console.WriteLine("Felaktig inmatning. Försök igen.");
            }
            // Console.WriteLine(guessedNumber);*/
            return guessedNumber; 
        }
        static int GenerateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);
      //      Console.WriteLine(randomNumber);  // skriver ut random nummret
            return randomNumber;
        }

        static void NumberCheck(int guessedNumber, int randomNumber)
        {
            int countdown = 5;
            for (int i = 1; i <= countdown; i++)
            {
                int newGuess;

                while (true)
                {
                    Console.Write("Kan du gissa?: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out newGuess) && newGuess != 0)
                    {
                        break; // undersöker om detta är en valid integer 
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning. Försök igen.");
                    }
                }

                guessedNumber = newGuess; // Uppdaterar det gissade nummret

                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Wohoo du klarade det!");
                    break;
                }
                else if (guessedNumber <= randomNumber)
                {
                    Console.WriteLine("Din gissning var för låg");
                }
                else
                {
                    Console.WriteLine("Din gissning var för hög");
                }

                if (Math.Abs(guessedNumber - randomNumber) <= 1)
                {
                    Console.WriteLine("Du är nära.");
                }

                if ((guessedNumber != randomNumber) && (i == 5))
                {
                    Console.WriteLine("Tyvärr inga fler gissningar kvar. Det rätta svaret var: " + randomNumber);
                }
            }
        }
    }
}