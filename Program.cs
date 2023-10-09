namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of cards you want to pick");
            String line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine($"{card}");
                }
            }
            else
            {
                Console.WriteLine("Number not valid! Try again.");
            }
        }
    }
}