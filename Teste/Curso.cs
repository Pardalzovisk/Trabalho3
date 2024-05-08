using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Trabalho3
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public Curso(string nome)
        {
            Nome = nome;
            Disciplinas = new List<Disciplina>();
        }
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }
    }
}