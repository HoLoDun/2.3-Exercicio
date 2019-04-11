using System;
using System.Collections.Generic;
using System.Text;

namespace 2.3 Exercicio.Modelo
{
    class Diciplina
    {
         public String matricula;

         public int periodo;

         public bool Matricular(Diciplina diciplina)
         {
             return this.periodo == diciplina.semestre;
         }

    }
}
