using Sintaxe.Models;



int numero = 5;
int contador = 1;

while (contador <= 10)
{
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 5)
    {
        break;
    }
}









//int numero = 5;

// Console.WriteLine($"{numero} x 1 = {numero * 1}");

//for(int contador = 0; contador <= 10; contador++)
//{
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}



















//Calculadora calc = new Calculadora();

//calc.Somar(10, 30);
//calc.Subtrair(10, 30);
//calc.Dividir(100, 30);
//calc.Multiplicar(10, 30);
//calc.Potencia(3, 3);
//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente(30);
//calc.RaizQuadrada(9);
//int numero = 10;

//Console.WriteLine(numero);

//Console.WriteLine("Incrementando o 10");
////numero = numero + 1;
//numero++;

//Console.WriteLine(numero);

//Console.WriteLine("Decrementando o 11");
////numero = numero + 1;
//numero--;

//Console.WriteLine(numero);












//bool choveu = true;
//bool estaTarde = true;

//if (!choveu && !estaTarde)
//{
//    Console.WriteLine("Vou pedalar");   
//}
//else
//{
//    Console.WriteLine("Vou pedalar outro dia");
//}























//bool possuiPresencaMinima = true;
//double Media = 7.5;

//if(possuiPresencaMinima &&  Media >= 7)
//{
//    Console.WriteLine("Aprovado!");
//}
//else
//{
//    Console.WriteLine("Reprovado!");
//}

















//bool eMaiorDeIdade = false;
//bool possuiAutorizacao = true;

//if (eMaiorDeIdade || possuiAutorizacao)
//{
//    Console.WriteLine("Entrada liberada!!");
//}
//else
//{ 
//    Console.WriteLine("Entrada não liberada!!");
//}































//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();






//switch(letra)
//{
//    case "a":
//    case "e":
//    case "i":
//    case "o":
//    case "u":
//        Console.WriteLine("Vogal");
//        break;
//    default:
//        Console.WriteLine("Não é uma vogal");
//        break;
//}




//if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
//{
//    Console.WriteLine("Vogal");
//}
//else
//{
//    Console.WriteLine("Não é uma vogal");
//}




//if(letra == "a")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "e")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "i")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "0")
//{
//    Console.WriteLine("Vogal");
//}
//else if (letra == "u")
//{
//    Console.WriteLine("Vogal");
//}
//else
//{
//    Console.WriteLine("Não é uma vogal");
//}

















//int quantidadeEmEstoque = 10;
//int quantidadeCompra = 0;
//bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

//Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
//Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//if(quantidadeCompra == 0)
//{
//    Console.WriteLine("Venda inválida!");
//}
//else if (possivelVenda)
//{
//    Console.WriteLine("Venda realizada!");
//}
//else
//{
//    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
//}



//string a = "15-";

////int b = 0;

//int.TryParse(a, out int b);


//Console.WriteLine(b); 
//Console.WriteLine("Conversão realizada com sucesso!");








//double a = 4 / (2 + 2);

//Console.WriteLine(a);



















//int a = 5;
//double b = a;

//long a = long.MaxValue;
//int b = Convert.ToInt32(a);

//int a = int.MaxValue;
//long b = a;

//Console.WriteLine(b);







//int inteiro = 5;
//string a = inteiro.ToString();



//Console.WriteLine(a);










// Cast - Castinh
//int a = Convert.ToInt32(null);
// int a = int.Parse(null);

//Console.WriteLine(a);












//int a = 10;
//int b = 20;

//int c = a + b;

// c = c + 5; // 30 + 5

// c += 5;

// c -= 5;

//Console.WriteLine(c);   


//DateTime dataAtual = DateTime.Now.AddDays(5);
//Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




//string apresentacao = "Olá, seja bem vindo";

//int quantidade = 1;
//Console.WriteLine("Valor da variável quantidade: " + quantidade);

//quantidade = 10;
//Console.WriteLine("Valor da variável quantidade: " + quantidade);

//double altura = 1.82;

//decimal preco = 1.80M;

//bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variável preco: " + preco);
//Console.WriteLine("Valor da variável condicao: " + condicao);

//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Caio";
//pessoa1.Idade = 20;

//pessoa1.Apresentar();

//Pessoa pessoa_FisicaRepresentacaoLegal =  new Pessoa();