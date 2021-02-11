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
           //Console.WriteLine(Name);
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
