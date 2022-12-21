using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-12-17 18:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

Console.WriteLine(data);















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C8"));


// double porcentagem = .3431;

// Console.WriteLine(porcentagem.ToString("p"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));






// int numero1 = 10;
// int  numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);










// Pessoa p1 = new Pessoa(nome: "Caio", sobrenome: "Lucas");
// Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Luiza");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();