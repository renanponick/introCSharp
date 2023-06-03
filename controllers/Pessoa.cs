using System;
using System.Collections.Generic;

namespace Controllers
{
    public static class PessoaController {

        public static void addPessoa(
            string nome,
            int idade,
            string endereco,
            bool vivo = true
        ){
            new Models.Pessoa(nome, idade, endereco, vivo);
        }

        public static List<Models.Pessoa> ListarPessoas(){
            return Repositories.PessoaRepository.getPessoas();
        }
        
    }
    
}