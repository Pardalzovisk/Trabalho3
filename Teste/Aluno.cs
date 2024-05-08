using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho3;

namespace Trabalho3
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Disciplinas = new List<Disciplina>();
        }

        public void Matricular(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
            disciplina.AdicionarAluno(this);
            Console.WriteLine($"{Nome} matriculado na disciplina {disciplina.Nome}.");
        }

        public void CancelarMatricula(Disciplina disciplina)
        {
            Disciplinas.Remove(disciplina);
            disciplina.RemoverAluno(this);
            Console.WriteLine($"{Nome} cancelou a matrícula na disciplina {disciplina.Nome}.");
        }

        public void ExibirDisciplinas()
        {
            Console.WriteLine($"Disciplinas de {Nome}:");
            foreach (var disciplina in Disciplinas)
            {
                Console.WriteLine($"- {disciplina.Nome}");
            }
        }
    }
}
