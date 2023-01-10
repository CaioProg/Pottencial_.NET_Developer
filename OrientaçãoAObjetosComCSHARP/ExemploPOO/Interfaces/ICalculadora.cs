using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces {
    public interface ICalculadora
    {
        // Métodos que não tem corpo são obritario a implementação
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        
        // Métodos que tem corpo são opcionail na implementação
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}