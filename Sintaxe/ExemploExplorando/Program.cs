using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Caio", "Lucas");
Pessoa p2 = new Pessoa("Maria", "Luiza");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();