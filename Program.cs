using System;
using System.Collections.Generic;

namespace introCSharp
{
    class Program
    {
        static void Main(string[] args) {
            int op = 0;
            do{
                Console.WriteLine("\n\n");
                Console.WriteLine("Informe uma opção abaixo: ");
                Console.WriteLine(
                    "1- Adicionar uma Pessoa\n"+
                    "2- Listar todas as Pessoa\n"+
                    "3- Sair \n"
                );
                op = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (op)
                {
                    case 1:{
                        Views.PessoaView.addPessoa();
                        break;
                    }
                    case 2:{
                        Views.PessoaView.ListarPessoas();
                        break;
                    }
                    case 3:{
                        break;
                    }
                    default:{
                        Console.WriteLine("Número inválido");
                        break;
                    }
                }
            }while(op!=3);
        }
    }
}
