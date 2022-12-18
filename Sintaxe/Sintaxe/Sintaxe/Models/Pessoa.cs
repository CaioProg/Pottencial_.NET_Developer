using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintaxe.Models
{
    /// <sumary>
    /// Representa uma pessoa física
    /// </sumary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        /// <sumary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade
        /// </sumary>
        public void Apresentar()
        {

            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
            //Console.WriteLine($"Olá, meu nome é {Nome},\n e tenho {Idade} anos");

        }
    }
}
