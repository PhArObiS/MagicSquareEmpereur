namespace MagicSquareEmpereur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la dimension du carré magique (entre 3 et 20) :");
            int x = int.Parse(Console.ReadLine());

            try
            {
                MagicSquare magicSquare = new MagicSquare(x);
                magicSquare.Print();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}