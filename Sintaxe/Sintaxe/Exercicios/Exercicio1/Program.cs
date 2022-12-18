﻿// Desafio
// Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.

// Entrada
// A entrada consiste em um número inteiro ( n );

// Saída
// A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

// Exemplo 1

// Entrada	Saída
// 234	15
// Explicação: 

// Produto de dígitos = 2 * 3 * 4 = 24

// Soma dos dígitos = 2 + 3 + 4 = 9

// Resultado = 24 - 9 = 15

// Exemplo 2:

// Entrada	Saída
// 4421	21
// Explicação: 

// Produto de dígitos = 4 * 4 * 2 * 1 = 32

// Soma dos dígitos = 4 + 4 + 2 + 1 = 11

// Resultado = 32 - 11 = 21

// Restrições:

// 1 <= n <= 10^5

using System;

class DIO {
        
    static void Main(string[] args){
        int numero = int.Parse(Console.ReadLine());
        int digito = 0, soma = 0, produto = 1;

            
            while (numero > 0){
                digito = numero % 10; // Retorna o último dígito
                soma += digito; // Faz a soma dos digito 
                produto *= digito; // Faz a multiplicação dos digito
                numero /= 10;
            }
                Console.WriteLine(produto-soma); // Retorna a diferenção entre o produto e a soma
            }
}