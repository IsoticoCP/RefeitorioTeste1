
namespace RefeitorioTeste
{
    partial class UserControl1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.g2panelborda_valido = new Guna.UI2.WinForms.Guna2Panel();
            this.g2GradientButton_Valid = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.g2panelborda_valido.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(13, 15);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(83, 23);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "5,00 €";
            // 
            // g2panelborda_valido
            // 
            this.g2panelborda_valido.BackColor = System.Drawing.Color.Transparent;
            this.g2panelborda_valido.BorderColor = System.Drawing.SystemColors.Highlight;
            this.g2panelborda_valido.BorderThickness = 3;
            this.g2panelborda_valido.Controls.Add(this.g2GradientButton_Valid);
            this.g2panelborda_valido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g2panelborda_valido.Location = new System.Drawing.Point(0, 0);
            this.g2panelborda_valido.Margin = new System.Windows.Forms.Padding(10);
            this.g2panelborda_valido.Name = "g2panelborda_valido";
            this.g2panelborda_valido.ShadowDecoration.Parent = this.g2panelborda_valido;
            this.g2panelborda_valido.Size = new System.Drawing.Size(246, 165);
            this.g2panelborda_valido.TabIndex = 2;
            this.g2panelborda_valido.Visible = false;
            this.g2panelborda_valido.Click += new System.EventHandler(this.g2panelborda_valido_Click);
            // 
            // g2GradientButton_Valid
            // 
            this.g2GradientButton_Valid.CheckedState.Parent = this.g2GradientButton_Valid;
            this.g2GradientButton_Valid.CustomImages.Parent = this.g2GradientButton_Valid;
            this.g2GradientButton_Valid.FillColor = System.Drawing.SystemColors.Highlight;
            this.g2GradientButton_Valid.FillColor2 = System.Drawing.SystemColors.Highlight;
            this.g2GradientButton_Valid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.g2GradientButton_Valid.ForeColor = System.Drawing.Color.White;
            this.g2GradientButton_Valid.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.g2GradientButton_Valid.HoverState.Parent = this.g2GradientButton_Valid;
            this.g2GradientButton_Valid.Image = ((System.Drawing.Image)(resources.GetObject("g2GradientButton_Valid.Image")));
            this.g2GradientButton_Valid.Location = new System.Drawing.Point(179, 129);
            this.g2GradientButton_Valid.Name = "g2GradientButton_Valid";
            this.g2GradientButton_Valid.ShadowDecoration.Parent = this.g2GradientButton_Valid;
            this.g2GradientButton_Valid.Size = new System.Drawing.Size(67, 36);
            this.g2GradientButton_Valid.TabIndex = 0;
            this.g2GradientButton_Valid.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.g2panelborda_valido);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(246, 165);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.g2panelborda_valido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel g2panelborda_valido;
        private Guna.UI2.WinForms.Guna2GradientButton g2GradientButton_Valid;
    }
}
