using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3
{
    public class Professor
    {
        public string Nome { get; set; }
        public List<Disciplina> DisciplinasMinistradas { get; set; }

        public Professor(string nome)
        {
            Nome = nome;
            DisciplinasMinistradas = new List<Disciplina>();
        }

        public void AtribuirDisciplina(Disciplina disciplina)
        {
            DisciplinasMinistradas.Add(disciplina);
            Console.WriteLine($"Disciplina {disciplina.Nome} atribuída ao professor {Nome}.");
        }

        public void RemoverDisciplina(Disciplina disciplina)
        {
            DisciplinasMinistradas.Remove(disciplina);
            Console.WriteLine($"Disciplina {disciplina.Nome} removida do professor {Nome}.");
        }

        public void ExibirDisciplinas()
        {
            Console.WriteLine($"Disciplinas ministradas pelo professor {Nome}:");
            foreach (var disciplina in DisciplinasMinistradas)
            {
                Console.WriteLine($"- {disciplina.Nome}");
            }
        }
    }
}
