using Trabalho3;
class Program
{
    static void Main(string[] args)
    {
        Professor prof = new Professor("João", "Matemática");
        Disciplina matematica = new Disciplina("Matemática", prof);

        Aluno aluno = new Aluno("Maria", 123456);
        aluno.AdicionarDisciplina(matematica);
        Console.WriteLine($"As disciplinas de {aluno.Nome} são:");
        foreach (var disciplina in aluno.Disciplinas)
        {
            Console.WriteLine(disciplina.Nome);
        }

        Curso curso = new Curso("Engenharia");
        curso.AdicionarDisciplina(matematica);
        Console.WriteLine($"\nAs disciplinas do curso de {curso.Nome} são:");
        foreach (var disciplina in curso.Disciplinas)
        {
            Console.WriteLine(disciplina.Nome);
        }
        prof.DarAula();
    }
}