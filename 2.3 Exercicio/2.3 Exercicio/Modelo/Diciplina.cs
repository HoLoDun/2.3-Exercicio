using System;
using System.Collections.Generic;
using System.Text;

namespace 2.3 Exercicio.Modelo
{
    class Diciplina
    {
        public String nome;

        public int semestre;

        public int professor;

        public Diciplina(String nome, int semestre, int professor)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.professor = professor;
        }
        public bool Lecionar(Profesor profesor)
        {
            return this.professor == professor.numero;
        }
    }
}
