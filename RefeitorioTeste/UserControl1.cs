using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RefeitorioTeste
{
    public partial class UserControl1 : UserControl
    {
        //Ajudado por ZacharyPatten
        public bool IsSelected //IsSelected é uma struct
        {
            get //quando IsSelected for chamado aquele valor "g2GradientButton_Valid.Visible;" vai ser-lhe retornado(SÓ QUANDO É CHAMADO) ao IsSelected
            {
                return g2GradientButton_Valid.Visible;
            }
            set 
            {
                g2GradientButton_Valid.Visible = value; //ganha o valor de false de IsSelected = !g2GradientButton_Valid.Visible; lá em baixo
                g2panelborda_valido.Visible = value;
            }

        }

        public Guna.UI2.WinForms.Guna2Panel G2panelborda_valido => g2panelborda_valido;

		//IsSelected = false;
		//ex: Console.WriteLine(IsSelected) a consola vai printar se o g2GrandientButton_Valid.Visible é true ou falso (se está visibel) (se setá selected ou nao)

		public UserControl1()
        {
            InitializeComponent();
        }
        public bool GradientVisible
        {
            get
            {
                return g2GradientButton_Valid.Visible;
            }
            set
            {
                g2GradientButton_Valid.Visible = value;
            }
        }
        /*g2panelborda_valido é o painel que ocupa o espaço todo quando o botão do certo está visivel
        UserControl1 só é clicável então quando o botão do certo não está visível (quando o g2panelborda_valido nao é clicável)
        por isso é que é necessário repetir o códio 2x para diferentes cliques.*/
        public void UserControl1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Parent.Controls)
            {
                if (control is UserControl1 userControl1)
                {
                    userControl1.IsSelected = false;
                }
            }
            IsSelected = !g2GradientButton_Valid.Visible; // = false e vai set o valor a "value" lá em cima
            

            //ALTERNATIVA - AJUDA PELO NYCK E ZACHARYPATTEN
            /*IsSelected = !g2GradientButton_Valid.Visible;
            foreach (Control control in Parent.Controls)  //para cada controlo dos controlos (2 controls, 1 para deifinir o tipo, outra para a variavel)
            {
                if (control is UserControl1 userControl1 && !ReferenceEquals(userControl1, this)) //polimorfismo de classes
                {
                    userControl1.IsSelected = false;
                    userControl1.g2GradientButton_Valid.Visible = false;
                    userControl1.g2panelborda_valido.Visible = false;
                    
                }
            }
            if (IsSelected == true)
            {
                g2GradientButton_Valid.Visible = true;
                g2panelborda_valido.Visible = true;
            }
            else
            {
                g2GradientButton_Valid.Visible = false;
                g2panelborda_valido.Visible = false;
            }
            //Console.WriteLine(g2GradientButton_Valid.Visible)
            //Console.WriteLine(Name);

            /*if (g2GradientButton_Valid.Visible == false) 
            {
                g2GradientButton_Valid.Visible = true; 
                g2panelborda_valido.Visible = true;
            }
            else
            {
                g2GradientButton_Valid.Visible = false; 
                g2panelborda_valido.Visible = false;
            }*/
        }

        private void g2panelborda_valido_Click(object sender, EventArgs e)
        {
            if (g2GradientButton_Valid.Visible == false)
            {
                g2GradientButton_Valid.Visible = true; 
                g2panelborda_valido.Visible = true;
            }
            else
            {
                g2GradientButton_Valid.Visible = false;
                g2panelborda_valido.Visible = false;
            }
        }


    }
}
