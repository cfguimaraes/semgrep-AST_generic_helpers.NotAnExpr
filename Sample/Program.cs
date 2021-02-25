using System;
namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Request request = new Request{ Input = "1|2" };

            // The error occurs in this instruction
            (int propA, int propB) = request.Input.ManipulateInput().Value;

            Console.WriteLine(propA);
            Console.WriteLine(propB);
            Console.WriteLine("Type [Enter] to exit");
            Console.ReadLine();
        }
    }
}
