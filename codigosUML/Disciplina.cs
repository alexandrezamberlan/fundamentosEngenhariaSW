using System.Collections.Generic;

public class Disciplina
{
	public int codigo;

	public String nome;

	public ICollection<Professor> professor;

	public ICollection<Turma> turma;

}
