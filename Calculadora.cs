namespace Calculadora
{
    class Calculadora
    {
        private double resultado;

        public double Somar(double a, double b)
        {
            resultado = a + b;
            return resultado;
        }

        public double Subtrair(double a, double b)
        {
            resultado = a - b;
            return resultado;
        }

        public double Multiplicar(double a, double b)
        {
            resultado = a * b;
            return resultado;
        }

        public double Dividir(double a, double b)
        {
            resultado = a / b;
            return resultado;
        }

        public void Zerar()
        {
            resultado = 0;
        }
    }
}
