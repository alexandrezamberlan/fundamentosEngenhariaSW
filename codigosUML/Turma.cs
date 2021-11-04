using System.Collections.Generic;

public class Turma
{
	public int codigo;

	public int ano;

	public int semestre;

	public Professor professor;

	public Curso curso;

	public ICollection<Aluno> alunos;

	public Disciplina disciplina;

}

