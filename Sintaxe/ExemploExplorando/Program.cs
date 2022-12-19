using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Caio";
p1.Sobrenome = "Lucas";

Pessoa p2 = new Pessoa();
p2.Nome = "Maria";
p2.Sobrenome = "Luiza";


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
















// Pessoa p1 = new Pessoa();

// p1.Nome = "Caio";
// p1.Sobrenome = "Lucas";
// p1.Idade = 1;
// p1.Apresentar();