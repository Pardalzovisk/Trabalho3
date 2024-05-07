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
        // Atributos
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        // Construtor
        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
            Disciplinas = new List<Disciplina>();
        }

        // Método para adicionar disciplina
        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }
    }
}
