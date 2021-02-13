
namespace RefeitorioTeste
{
	partial class CarneButtonUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarneButtonUserControl));
			this.butCarne1 = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.hoverDarkeningPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// butCarne1
			// 
			this.butCarne1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.butCarne1.Animated = true;
			this.butCarne1.AnimatedGIF = true;
			this.butCarne1.BackColor = System.Drawing.Color.Transparent;
			this.butCarne1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCarne1.BackgroundImage")));
			this.butCarne1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.butCarne1.CheckedState.Parent = this.butCarne1;
			this.butCarne1.CustomImages.Parent = this.butCarne1;
			this.butCarne1.FillColor = System.Drawing.Color.Transparent;
			this.butCarne1.FillColor2 = System.Drawing.Color.Transparent;
			this.butCarne1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.butCarne1.ForeColor = System.Drawing.Color.Transparent;
			this.butCarne1.HoverState.Parent = this.butCarne1;
			this.butCarne1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
			this.butCarne1.Location = new System.Drawing.Point(45, 47);
			this.butCarne1.Name = "butCarne1";
			this.butCarne1.ShadowDecoration.Parent = this.butCarne1;
			this.butCarne1.Size = new System.Drawing.Size(90, 81);
			this.butCarne1.TabIndex = 30;
			this.butCarne1.Text = "guna2GradientButton1";
			// 
			// guna2HtmlLabel8
			// 
			this.guna2HtmlLabel8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
			this.guna2HtmlLabel8.Location = new System.Drawing.Point(60, 192);
			this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
			this.guna2HtmlLabel8.Size = new System.Drawing.Size(59, 26);
			this.guna2HtmlLabel8.TabIndex = 31;
			this.guna2HtmlLabel8.Text = "Carne";
			// 
			// hoverDarkeningPanel
			// 
			this.hoverDarkeningPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.hoverDarkeningPanel.Location = new System.Drawing.Point(0, 0);
			this.hoverDarkeningPanel.Name = "hoverDarkeningPanel";
			this.hoverDarkeningPanel.Size = new System.Drawing.Size(190, 186);
			this.hoverDarkeningPanel.TabIndex = 32;
			// 
			// CarneButtonUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.guna2HtmlLabel8);
			this.Controls.Add(this.butCarne1);
			this.Controls.Add(this.hoverDarkeningPanel);
			this.Name = "CarneButtonUserControl";
			this.Size = new System.Drawing.Size(190, 231);
			this.MouseEnter += new System.EventHandler(this.CarneButtonUserControl_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.CarneButtonUserControl_MouseLeave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2GradientButton butCarne1;
		private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
		private System.Windows.Forms.Panel hoverDarkeningPanel;
	}
}
