using Trabalho3;
class Program
{
        static void Main(string[] args)
        {
            var professor1 = new Professor("João");
            var professor2 = new Professor("Maria");

            var disciplina1 = new Disciplina("Matemática", professor1);
            var disciplina2 = new Disciplina("Português", professor2);

            var aluno1 = new Aluno("Pedro", 1);
            var aluno2 = new Aluno("Ana", 2);

            professor1.AtribuirDisciplina(disciplina1);
            professor2.AtribuirDisciplina(disciplina2);

            aluno1.Matricular(disciplina1);
            aluno2.Matricular(disciplina2);
            
            disciplina1.ExibirAlunos();
            disciplina2.ExibirAlunos();

            professor1.ExibirDisciplinas();
            professor2.ExibirDisciplinas();

            aluno1.CancelarMatricula(disciplina1);

            aluno1.ExibirDisciplinas();
            aluno2.ExibirDisciplinas();
        }
}