using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adsadadsdada
//width = 204
//width = 92
namespace RefeitorioTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool Expanded = false;
        private void DetetarMouse_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;

            if (painelPrincipal.ClientRectangle.Contains(PointToClient(Control.MousePosition))) //se o mouse estiver/passar pelo painel principal
            {
                //if (!Expanded) é a mesma coisa
                if (Expanded == false) //nao entendi este Expanded professor
                {
                    painelPrincipal.Width = 204;
                    butInicio.Location = new Point(100, 164); // y constante = 164 e x = 3 posição inicial
                    butPratos.Location = new Point(100, 343); // y constante = 343 e x = 3 posição inicial
                    butBebidas.Location = new Point(100, 515); // y constante = 531 e x = 3 posição inicial
                    //g2painelPratos.Visible = true;
                    painelPrincipal.BringToFront();
                    Expanded = true; //o Expanded é a expansao para a direita (Expanded = true significa que está expandido para a direita)

                }
            }
            else
            {
                if (Expanded == true) //se estiver expandido e o cursor já não estiver a passar pelo painel principal então desexpandimos
                {
                    painelPrincipal.Visible = false;
                    painelPrincipal.Width = 92;
                    guna2Transition1.Show(painelPrincipal);
                    butInicio.Location = new Point(3, 164);
                    butPratos.Location = new Point(3, 343);
                    butBebidas.Location = new Point(3, 515); //Bebidas, Sobremesas e Acompanhamentos
                    butCarteira.Location = new Point(3, 677);
                    Expanded = false;
                }
            }
        }
        private void butPratos_Click(object sender, EventArgs e)
        {
            g2painelBebidas.Visible = false;
            g2painelPratos.Visible = true; //quando clico no botão dos pratos, os tipos de pratos aparecem e os botoes iniciais/principais voltam à posição inicial
            butInicio.Location = new Point(3, 164);
            butPratos.Location = new Point(3, 343);
            butBebidas.Location = new Point(3, 515);
            butCarteira.Location = new Point(3, 677);
            painelPrincipal.SendToBack();
            painelCarnes.Visible = true;
        }
        private void butCarne1_Click(object sender, EventArgs e)
        {
            if (painelCarnes.Visible == false)
            {
                painelPeixes.Visible = false;
                painelCarnes.Visible = true;
                painelVegetariano.Visible = false;
            }
            else
            {
                painelCarnes.Visible = true;
                painelPeixes.Visible = false ;
                painelVegetariano.Visible = false;
            }
        }
        private void butPeixe1_Click(object sender, EventArgs e)
        {
            if (painelPeixes.Visible == false)
            {
                painelCarnes.Visible = true; // nao entendo bem
                painelPeixes.Visible = true;
                painelVegetariano.Visible = false;

            }
            else
            {
                painelPeixes.Visible = true;
                painelCarnes.Visible = true;
                painelVegetariano.Visible = false;
            }
        }
        private void butVegetariano1_Click(object sender, EventArgs e)
        {
            if (painelVegetariano.Visible == false)
            {
                painelVegetariano.Visible = true;
                painelCarnes.Visible = true;
                painelPeixes.Visible = false;

            }
            else
            {
                painelVegetariano.Visible = true;
                painelPeixes.Visible = false;
                painelCarnes.Visible = false;
            }
        }
        private void butInicio_Click(object sender, EventArgs e)
        {
            g2painelPratos.Visible = false;
            butInicio.Location = new Point(3, 164);
            butPratos.Location = new Point(3, 343);
            butBebidas.Location = new Point(3, 515);
            butCarteira.Location = new Point(3, 677);
            painelCarnes.Visible = false;
            painelPeixes.Visible = false;
            painelVegetariano.Visible = false;
            g2painelPratos.Visible = false;
            g2painelBebidas.Visible = false;
            painelPrincipal.SendToBack();
            Expanded = true;
        }
        private void butCalcular_Click(object sender, EventArgs e) //esta função é chamada no click do botão calcular
        {
            double total = 0;

            if (butCalcular.Text == "Calcular o preço a pagar")
            {
                //ao clicar no botão, se o texto estiver "Calcular o preço a pagar", verificam-se os botões checked (condições sguintes) e calcula-se o total
                butCalcular.Text = "Novo";
                if (rbutCarne.Checked == true)
                    total = total + 5.00;
                if (rbutPeixe.Checked == true)
                    total = total + 5.00;
                if (rbutVegetariano.Checked == true)
                    total = total + 6.00;
                if (chkSalada.Checked == true)
                    total = total + 0.50;
                if (chkBebida.Checked == true)
                    total = total + 1.00;
                if (chkCafe.Checked == true)
                    total = total + 0.60;
                if (chkSopa.Checked == true)
                    total = total + 1.20;
                if (chkSobremesa.Checked == true)
                    total = total + 2.00;
                if (chkPao.Checked == true)
                    total = total + 0.20;
                lblTotal.Text = $"{total:0.00} €";
                //lblTotal.Text = string.Format("{0:0.00}, total");
                //$"{String.Format("{0:0.00}", total)} € ";
                //$"{total:0.00} €";
                //não entendo o porquê de aparecer uma vírgula em vez de um ponto
                rbutCarne.Checked = false;
                rbutCarne.Checked = false;
                rbutPeixe.Checked = false;
                rbutVegetariano.Checked = false;
                chkSalada.Checked = false;
                chkBebida.Checked = false;
                chkCafe.Checked = false;
                chkSopa.Checked = false;
                chkSobremesa.Checked = false;
                chkPao.Checked = false;
                rbutCarne.Enabled = false;
                rbutPeixe.Enabled = false;
                rbutVegetariano.Enabled = false;
                chkSalada.Enabled = false;
                chkBebida.Enabled = false;
                chkCafe.Enabled = false;
                chkSopa.Enabled = false;
                chkSobremesa.Enabled = false;
                chkPao.Enabled = false;
            }
            else
            {
                rbutCarne.Enabled = true;
                rbutPeixe.Enabled = true;
                rbutVegetariano.Enabled = true;
                chkSalada.Enabled = true;
                chkBebida.Enabled = true;
                chkCafe.Enabled = true;
                chkSopa.Enabled = true;
                chkSobremesa.Enabled = true;
                chkPao.Enabled = true;

                lblTotal.Text = "0,00 €";
                //total = 0; esta linha é irrelevante mas se eu não tivesse o double total = 0 no início então já faria sentido
                butCalcular.Text = "Calcular o preço a pagar";
                rbutCarne.Checked = true;
                rbutPeixe.Checked = false;
                rbutVegetariano.Checked = false;

                chkBebida.Checked = false;
                chkCafe.Checked = false;
                chkPao.Checked = false;
                chkSalada.Checked = false;
                chkSalada.Checked = false;
                chkSobremesa.Checked = false;

            }
        }

        private void rbutCarne_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                rbutCarne.Checked = false;

        }

        private void rbutPeixe_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                rbutPeixe.Checked = false;
        }

        private void rbutVegetariano_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                rbutVegetariano.Checked = false;
        }

        private void chkSopa_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                chkSopa.Checked = false;
        }

        private void chkBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                chkBebida.Checked = false;
        }

        private void chkSobremesa_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                chkSobremesa.Checked = false;
        }

        private void chkPao_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                chkPao.Checked = false;
        }

        private void chkSalada_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                chkSalada.Checked = false;
        }

        private void chkCafe_CheckedChanged(object sender, EventArgs e)
        {
            if (butCalcular.Text == "Novo")
                chkCafe.Checked = false;
        }

        private void userControl_FrangoChurrasco_Click(object sender, EventArgs e)
        {//podia fzr aqui umas condições para conseguir remover as compras quando clicasse outra vez no produto mas ainda não sei aceder ao UserControl no forms
            painelCompra1.Visible = true;
            labelCompra1.Text = "Frango Churrasco";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
            
        }

        private void butDelete1_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = false;
            labelCompra1.Text = "";
            labelCompra1.Visible = false;
        }

        private void userControl_CozidoPT_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Cozido à Portuguesa";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl_Alcatra_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Alcatra";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl11_Click(object sender, EventArgs e) //Anho Assado com Arroz de Frango
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Anho Assado com Arroz de Frango";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl12_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Corvina estufada com legumes";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl13_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Bacalhau à Braga";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl14_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Cantaril assado no forno com legumes";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl15_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Pescada à Portuguesa";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl17_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Húmus de beterraba";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl18_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Creme de cogumelos e queijo da ilha";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void userControl19_Click(object sender, EventArgs e)
        {
            painelCompra1.Visible = true;
            labelCompra1.Text = "Facaccia pugliese";
            labelCompra1.Visible = true;
            labelMax1.Visible = true;
        }

        private void butBebidas_Click(object sender, EventArgs e)
        {
            painelCarnes.Visible = false;
            painelPeixes.Visible = false;
            painelVegetariano.Visible = false;
            g2painelBebidas.Visible = true;
            g2painelPratos.Visible = false;
            butInicio.Location = new Point(3, 164);
            butPratos.Location = new Point(3, 343);
            butBebidas.Location = new Point(3, 515);
            butCarteira.Location = new Point(3, 677);
            painelPrincipal.SendToBack();
            g2painelBebidas.Visible = true;
            /*g2painelPratos.Visible = false;
            g2painelBebidas.Visible = false;
            butInicio.Location = new Point(3, 164);
            butPratos.Location = new Point(3, 343);
            butBebidas.Location = new Point(3, 515);
            butCarteira.Location = new Point(3, 677);
            painelPrincipal.SendToBack();
            g2painelBebidas.BringToFront();*/

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form form = new Form();
        //    PratosViewUserControl uc = new PratosViewUserControl();
        //    uc.Dock = DockStyle.Fill;
        //    form.Controls.Add(uc);
        //    form.ShowDialog();
        //}
    }
}
