using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Trabalho3
{
    public class Curso
    {
        // Atributos
        public string Nome { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        // Construtor
        public Curso(string nome)
        {
            Nome = nome;
            Disciplinas = new List<Disciplina>();
        }

        // Método para adicionar disciplina ao curso
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }
    }
}