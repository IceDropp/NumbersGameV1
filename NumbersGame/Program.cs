namespace NumbersGame
{
    internal class Program
    {
        static int GetGuesedNumber()
        {
            Console.WriteLine("Välkommen jag tänker på ett nummer kan du gissa vilket? Du får fem försök");

            int guessedNumber;
            if (!int.TryParse(Console.ReadLine(), out guessedNumber))
            {
                Console.WriteLine("Felaktig inmatning. Försök igen.");
                guessedNumber = GetGuesedNumber(); // Recursively prompt for input.
            }
            // Console.WriteLine(guessedNumber);
            return guessedNumber;
        }
        static int GenerateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 20);
            Console.WriteLine(randomNumber);
            return randomNumber;
        }

        static void NumberCheck(int guessedNumber, int randomNumber)
        {
            int countdown = 5;
            for (int i = 1; i < countdown; i++)
            {

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
                Console.Write("Gissa igen: ");
                //        guessedNumber = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out guessedNumber) && Math.Abs(guessedNumber - randomNumber) <= 1)
                {
                    i = -1;
                    int g = 0;
                    g++;
                    Console.WriteLine($"g"+g);

                    Console.WriteLine("Du är nära.");
                }
 /*               if (Math.Abs(guessedNumber - randomNumber) <= 1)
                    {
                        Console.WriteLine("Du är nära.");
                    }
 */             
                if ((guessedNumber != randomNumber) && (i == 4))
                {
                    Console.WriteLine("Tyvärr inga fler gissningar kvar. Det rätta svaret var: " + randomNumber);
                }
            }
        }
            static void Main()
            {
                int randomNumber = GenerateRandomNumber();
                int guessedNumber = GetGuesedNumber();
                NumberCheck(guessedNumber, randomNumber);

                Console.ReadLine();
            }
    }
}