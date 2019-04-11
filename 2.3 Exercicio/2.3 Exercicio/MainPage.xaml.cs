using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using 2._3_Exercicio.Modelo;

namespace _2._3_Exercicio
{
    public partial class MainPage : ContentPage
    {
        Diciplina[] diciplinas = new Diciplina[4]
        {
            new Diciplina("Calculo 1", 1, 9001),
            new Diciplina("Introdução a Engenharia", 1, 9002),
            new Diciplina("Calculo 2", 2, 9003),
            new Diciplina("Projetos Aplicados", 4, 9004)
        };

        Professor[] professores = new Professor[4]
        {
            new Professor("Paulo Fantin", 9001),
            new Professor("Josemar", 9002),
            new Professor("Andre", 9003),
            new Professor("Renata", 9004)
        };



        public MainPage()
		{
			InitializeComponent();
            foreach (Diciplina diciplina in diciplinas)
            {
                Picker1.Items.Add(diciplina.semestre + " - " + diciplina.nome);
            }
            
            foreach (Professor professor in professores)
            {
                Picker2.Items.Add(professor.nome);
            }
		}

        void ButtonClicked(object Sender, EventArgs args)
        {
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label3.IsVisible = false;

            if(Picker1.SelectedIndex >= 0 && Picker2.SelectedIndex >= 0 && Entry1.Text != null && Entry1.Text.Length > 0 && Entry2.Text != null && Entry2.Text.Length > 0)
            {
                Aluno aluno = new Aluno();
                aluno.matricula = int.Parse(Entry1.Text);
                Notas notas = new Notas();
                Notas.valor = int.Parse(Entry2.Text);

                if (diciplinas[Picker1.SelectedIndex].Lecionar(professores[Picker2.SelectedIndex]))
                {
                    if (notas.Aprovar()){

                        Label2.IsVisible = true;

                    }else{

                        Label3.IsVisible = true;
                    }
                }else{

                    Label1.IsVisible = true;
                }
            }
            else
            {
                Label1.IsVisible = true;
            }      
        }
	}
}
