using Atividade_2;
Disciplina disciplina = new Disciplina();
disciplina.CargaHoraria = 72;
disciplina.Nome = "DSII";

Professor professor = new Professor();
professor.Nome = "Fran";
professor.titulo = "123456";

Aluno aluno = new Aluno();
aluno.Nome = "Micael";
aluno.Matricula = "021.718875";
aluno.Serie = 7;

Aluno aluno1 = new Aluno();
aluno1.Nome = "Bruno";
aluno1.Matricula = "021.123456";
aluno1.Serie = 5;

Avaliacao avaliacao = new Avaliacao();
avaliacao.Nome = "Prova SuperCats";
avaliacao.Nota = 10f;
avaliacao.Serie = 7;
avaliacao.Aluno = aluno;
avaliacao.Disciplina = disciplina;
avaliacao.Professor = professor;


Avaliacao avaliacao1 = new Avaliacao();
avaliacao1.Nome = "Prova Supercats";
avaliacao1.Nota = 10f;
avaliacao1.Serie = 7;
avaliacao1.Aluno = aluno1;
avaliacao1.Disciplina = disciplina;
avaliacao1.Professor = professor;

Console.WriteLine(avaliacao.ToString()); 
Console.WriteLine(avaliacao1.ToString()); 

