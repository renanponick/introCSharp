using System;

namespace introCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Criando nosso primeiro objeto: ");
            // Pessoa pessoa1 = new Pessoa{
            //     Nome = "João Pedro",
            //     Idade = 20,
            //     Email = "joaozinhoreidelas@hotmail.com",
            //     Endereco = "João Costa",
            //     Telefone = "(47) 99999-9999",
            // };
            // Console.WriteLine("Informações:\n" + pessoa1.ToString());
            // // Pessoa pessoa2 = new Pessoa{};
            // // pessoa2.Nome = "João Pedro";
            // // pessoa2.Idade = 20;
            // // pessoa2.Email = "joaozinhoreidelas@hotmail.com";
            // // pessoa2.Endereco = "João Costa";
            // // pessoa2.Telefone = "(47) 99999-9999";
            // // Console.WriteLine("Informações:\n" + pessoa2.ToString());

            // int numeroPessoas = 5;
            // Pessoa[] pessoas = new Pessoa[numeroPessoas];
            
            // decimal mediaIdade = 0;
            // // fazer o calculo da media de idade
            // for (int i = 0; i < numeroPessoas; i++) {
            //     mediaIdade += Convert.ToDecimal(pessoas[i]);
            // }
            // mediaIdade = mediaIdade / numeroPessoas;
            // Console.WriteLine("A media de idade é: " + mediaIdade);

            // // Buscando pessoa

            // Console.WriteLine("Digite o nome da pessoa para buscar: ");
            // string nome = Console.ReadLine();
            // for (int i = 0; i < numeroPessoas; i++)
            // {
            //     if (pessoas[i].Nome == nome)
            //     {
            //         Console.WriteLine(pessoas[i]);
            //     }
            // }

            Animal animal = new Animal("Animal");
            Cat cat = new Cat("Miau");
            Dog dog = new Dog("Rex");

            animal.MakeSound();
            cat.MakeSound();
            dog.MakeSound();

            dog.Bark();

        }
    }
}

