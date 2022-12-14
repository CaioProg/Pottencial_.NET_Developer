using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_e_Tipos_de_Dados_em_CSHARP.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar(string @class)
        {
            @class = "teste";
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {idade} anos");
        }  
    }
}