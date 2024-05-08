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
        public Professor ProfessorResponsavel { get; set; }
        public Disciplina(string nome, Professor professor)
        {
            Nome = nome;
            ProfessorResponsavel = professor;
        }
    }
}
