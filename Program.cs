namespace September13Övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej!, vem pratar jag med?");

            string svar = Console.ReadLine();

            Console.WriteLine($"Trevligt {svar} mår du bra idag?");

            string svar2 = Console.ReadLine();

            if (svar2 == "Ja")
            {
                Console.WriteLine("Skönt att höra!");
            }else if (svar2 == "Nej")
            {
                Console.WriteLine("Ojdå!, tråkigt.");
            }

            Console.WriteLine("Vad kan jag hjälpa dig med då?");

            Console.ReadLine();

            Console.WriteLine("Tyvärr det kan jag inte hjälpa dig med.");

        }
    }
}