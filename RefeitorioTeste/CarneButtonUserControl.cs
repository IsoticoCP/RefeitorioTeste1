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
	public partial class CarneButtonUserControl : UserControl
	{
		public CarneButtonUserControl()
		{
			InitializeComponent();
		}

		Color originalColor;
		private void CarneButtonUserControl_MouseEnter(object sender, EventArgs e)
		{
			originalColor = hoverDarkeningPanel.BackColor;
			hoverDarkeningPanel.BackColor = Color.Black;
		}

		private void CarneButtonUserControl_MouseLeave(object sender, EventArgs e)
		{
			hoverDarkeningPanel.BackColor = originalColor;
		}
	}
}
