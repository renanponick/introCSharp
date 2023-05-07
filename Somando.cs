using System;

namespace introCSharp
{
    public class Somando
    {
        public static void Somar()
        {
            Console.WriteLine("Somando dois números: ");
            int num1, num2;
            Console.WriteLine("Infome o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Infome o segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            // return num1 + num2;
        }
    }
}
