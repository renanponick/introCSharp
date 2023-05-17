using System;

namespace introCSharp
{
    // publica class Calcular
    public class Somando
    {
        // A função poderá ter parâmetros, porém, os valores serão solicitados na main
        public static void Somar()
        {
            Console.WriteLine("Somando dois números: ");
            int num1, num2;
            Console.WriteLine("Infome o primeiro número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Infome o segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            // Para que a função tenha retorno é necessario mudar a tipagem void
            // return num1 + num2;
        }

        public static int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
