using System;
using System.Collections.Generic;
using System.Text;

namespace 2.3 Exercicio.Modelo
{
    class Notas
    {
        public String aluno;

        public String diciplina;

        public int valor;

    public bool Aprovar()
    {
        return (valor > 5);
    }
}
