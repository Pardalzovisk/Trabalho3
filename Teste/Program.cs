using Trabalho3;
class Program
{
    static void Main(string[] args)
    {
        // Criando um professor
        Professor prof = new Professor("João", "Matemática");

        // Criando uma disciplina
        Disciplina matematica = new Disciplina("Matemática", prof);

        // Criando um aluno
        Aluno aluno = new Aluno("Maria", 123456);

        // Adicionando a disciplina ao aluno
        aluno.AdicionarDisciplina(matematica);

        // Exibindo as disciplinas do aluno
        Console.WriteLine($"As disciplinas de {aluno.Nome} são:");
        foreach (var disciplina in aluno.Disciplinas)
        {
            Console.WriteLine(disciplina.Nome);
        }

        // Criando um curso
        Curso curso = new Curso("Engenharia");

        // Adicionando a disciplina ao curso
        curso.AdicionarDisciplina(matematica);

        // Exibindo as disciplinas do curso
        Console.WriteLine($"\nAs disciplinas do curso de {curso.Nome} são:");
        foreach (var disciplina in curso.Disciplinas)
        {
            Console.WriteLine(disciplina.Nome);
        }

        // Professor dando aula
        prof.DarAula();
    }
}