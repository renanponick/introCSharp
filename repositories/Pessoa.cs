using System;
using System.Collections.Generic;
using Models;

namespace Repositories
{
    public class PessoaRepository {

        static List<Models.Pessoa> pessoas = new List<Models.Pessoa>();
        
        public static void addPessoas(Models.Pessoa funcionario) {
            pessoas.Add(funcionario);
        }

        public static List<Models.Pessoa> getPessoas() {
            return pessoas;
        }
    }
}