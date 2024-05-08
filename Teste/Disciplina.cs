using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> AlunosMatriculados { get; set; }

        public Disciplina(string nome, Professor professor)
        {
            Nome = nome;
            Professor = professor;
            AlunosMatriculados = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            AlunosMatriculados.Add(aluno);
            Console.WriteLine($"Aluno {aluno.Nome} adicionado à disciplina {Nome}.");
        }

        public void RemoverAluno(Aluno aluno)
        {
            AlunosMatriculados.Remove(aluno);
            Console.WriteLine($"Aluno {aluno.Nome} removido da disciplina {Nome}.");
        }

        public void ExibirAlunos()
        {
            Console.WriteLine($"Alunos matriculados na disciplina {Nome}:");
            foreach (var aluno in AlunosMatriculados)
            {
                Console.WriteLine($"- {aluno.Nome}");
            }
        }
    }
}
