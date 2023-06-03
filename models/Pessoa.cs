using System;

namespace Models
{
    public class Pessoa : Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public bool Vivo { get; set; }

        public Pessoa(
            string nome,
            int idade,
            string endereco,
            bool vivo = true
        ) {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Vivo = vivo;

            Repositories.PessoaRepository.addPessoas(this);
        }

        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome}. E tenho {Idade} anos. Moro em {Endereco}");
        }
        public void Despedida(){
            Console.WriteLine("Txau");
        }

        public override string ToString(){
            return $"----\n Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\n Login: {Login}\n Email: {Email}\n Senha: {Senha}\n Vivo: {Vivo}";
        }
        
    }
}