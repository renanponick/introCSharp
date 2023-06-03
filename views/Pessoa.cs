using System;
namespace Views
{
    public class PessoaView
    {
        public static void addPessoa(){
            // int id = Controllers.Pessoa.getPeaddPessoas().Count+1;
            string nome, endereco;
            bool vivo;
            int idade;

            try{
                Console.WriteLine("Digite o Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite o endereco: ");
                endereco = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Está vivo? 0 - sim / 1 - não");
                vivo = Convert.ToBool(Console.ReadLine());


                Controllers.PessoaController.addPessoa(nome, endereco, idade, vivo);
            }catch(Exception e){
                    Console.WriteLine($"Erro: {e}");
            }
        }

        public static void ListarPessoas(){
            Console.WriteLine(" - Lista de Pessoas cadastrados - ");

            foreach(Models.Pessoa Pessoa in Controllers.Pessoa.ListarPessoas()){
                Console.WriteLine(Pessoa);
            }
        }
    }
}