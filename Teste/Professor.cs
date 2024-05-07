﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho3
{
    public class Professor
    {
        // Atributos
        public string Nome { get; set; }
        public string Disciplina { get; set; }

        // Construtor
        public Professor(string nome, string disciplina)
        {
            Nome = nome;
            Disciplina = disciplina;
        }

        // Método para dar aula
        public void DarAula()
        {
            Console.WriteLine($"{Nome} está dando aula de {Disciplina}");
        }
    }
}