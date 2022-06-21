namespace Biblioteca
{
    partial class CadLivro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNcadL = new System.Windows.Forms.Button();
            this.TXTdataL = new System.Windows.Forms.TextBox();
            this.LBLdataL = new System.Windows.Forms.Label();
            this.TXTisbnL = new System.Windows.Forms.TextBox();
            this.LBLisbnL = new System.Windows.Forms.Label();
            this.TXTlinguaL = new System.Windows.Forms.TextBox();
            this.LBLlingua = new System.Windows.Forms.Label();
            this.TXTanoL = new System.Windows.Forms.TextBox();
            this.LBLanoL = new System.Windows.Forms.Label();
            this.TXTtiltuloL = new System.Windows.Forms.TextBox();
            this.LBLtituloL = new System.Windows.Forms.Label();
            this.LBLcadL = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltaralu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNcadL
            // 
            this.BTNcadL.Location = new System.Drawing.Point(171, 276);
            this.BTNcadL.Name = "BTNcadL";
            this.BTNcadL.Size = new System.Drawing.Size(75, 23);
            this.BTNcadL.TabIndex = 23;
            this.BTNcadL.Text = "Cadastrar";
            this.BTNcadL.UseVisualStyleBackColor = true;
            this.BTNcadL.Click += new System.EventHandler(this.BTNcadL_Click);
            // 
            // TXTdataL
            // 
            this.TXTdataL.Location = new System.Drawing.Point(209, 236);
            this.TXTdataL.Name = "TXTdataL";
            this.TXTdataL.Size = new System.Drawing.Size(100, 20);
            this.TXTdataL.TabIndex = 22;
            this.TXTdataL.TextChanged += new System.EventHandler(this.TXTdataL_TextChanged);
            // 
            // LBLdataL
            // 
            this.LBLdataL.AutoSize = true;
            this.LBLdataL.Location = new System.Drawing.Point(113, 239);
            this.LBLdataL.Name = "LBLdataL";
            this.LBLdataL.Size = new System.Drawing.Size(90, 13);
            this.LBLdataL.TabIndex = 21;
            this.LBLdataL.Text = "Data de Registro:";
            this.LBLdataL.Click += new System.EventHandler(this.LBLdataL_Click);
            // 
            // TXTisbnL
            // 
            this.TXTisbnL.Location = new System.Drawing.Point(209, 207);
            this.TXTisbnL.Name = "TXTisbnL";
            this.TXTisbnL.Size = new System.Drawing.Size(100, 20);
            this.TXTisbnL.TabIndex = 20;
            this.TXTisbnL.TextChanged += new System.EventHandler(this.TXTisbnL_TextChanged);
            // 
            // LBLisbnL
            // 
            this.LBLisbnL.AutoSize = true;
            this.LBLisbnL.Location = new System.Drawing.Point(168, 210);
            this.LBLisbnL.Name = "LBLisbnL";
            this.LBLisbnL.Size = new System.Drawing.Size(35, 13);
            this.LBLisbnL.TabIndex = 19;
            this.LBLisbnL.Text = "ISBN:";
            this.LBLisbnL.Click += new System.EventHandler(this.LBLisbnL_Click);
            // 
            // TXTlinguaL
            // 
            this.TXTlinguaL.Location = new System.Drawing.Point(209, 174);
            this.TXTlinguaL.Name = "TXTlinguaL";
            this.TXTlinguaL.Size = new System.Drawing.Size(100, 20);
            this.TXTlinguaL.TabIndex = 18;
            this.TXTlinguaL.TextChanged += new System.EventHandler(this.TXTlinguaL_TextChanged);
            // 
            // LBLlingua
            // 
            this.LBLlingua.AutoSize = true;
            this.LBLlingua.Location = new System.Drawing.Point(159, 177);
            this.LBLlingua.Name = "LBLlingua";
            this.LBLlingua.Size = new System.Drawing.Size(44, 13);
            this.LBLlingua.TabIndex = 17;
            this.LBLlingua.Text = "Língua:";
            this.LBLlingua.Click += new System.EventHandler(this.LBLlingua_Click);
            // 
            // TXTanoL
            // 
            this.TXTanoL.Location = new System.Drawing.Point(209, 141);
            this.TXTanoL.Name = "TXTanoL";
            this.TXTanoL.Size = new System.Drawing.Size(100, 20);
            this.TXTanoL.TabIndex = 16;
            this.TXTanoL.TextChanged += new System.EventHandler(this.TXTanoL_TextChanged);
            // 
            // LBLanoL
            // 
            this.LBLanoL.AutoSize = true;
            this.LBLanoL.Location = new System.Drawing.Point(104, 144);
            this.LBLanoL.Name = "LBLanoL";
            this.LBLanoL.Size = new System.Drawing.Size(99, 13);
            this.LBLanoL.TabIndex = 15;
            this.LBLanoL.Text = "Ano de publicação:";
            this.LBLanoL.Click += new System.EventHandler(this.LBLanoL_Click);
            // 
            // TXTtiltuloL
            // 
            this.TXTtiltuloL.Location = new System.Drawing.Point(209, 105);
            this.TXTtiltuloL.Name = "TXTtiltuloL";
            this.TXTtiltuloL.Size = new System.Drawing.Size(100, 20);
            this.TXTtiltuloL.TabIndex = 14;
            this.TXTtiltuloL.TextChanged += new System.EventHandler(this.TXTtiltuloL_TextChanged);
            // 
            // LBLtituloL
            // 
            this.LBLtituloL.AutoSize = true;
            this.LBLtituloL.Location = new System.Drawing.Point(165, 108);
            this.LBLtituloL.Name = "LBLtituloL";
            this.LBLtituloL.Size = new System.Drawing.Size(38, 13);
            this.LBLtituloL.TabIndex = 13;
            this.LBLtituloL.Text = "Título:";
            this.LBLtituloL.Click += new System.EventHandler(this.LBLtituloL_Click);
            // 
            // LBLcadL
            // 
            this.LBLcadL.AutoSize = true;
            this.LBLcadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LBLcadL.Location = new System.Drawing.Point(116, 48);
            this.LBLcadL.Name = "LBLcadL";
            this.LBLcadL.Size = new System.Drawing.Size(193, 25);
            this.LBLcadL.TabIndex = 12;
            this.LBLcadL.Text = "Cadastro de Livros";
            this.LBLcadL.Click += new System.EventHandler(this.LBLcadL_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltaralu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltaralu2
            // 
            this.voltaralu2.Name = "voltaralu2";
            this.voltaralu2.Size = new System.Drawing.Size(49, 20);
            this.voltaralu2.Text = "Voltar";
            // 
            // CadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 387);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BTNcadL);
            this.Controls.Add(this.TXTdataL);
            this.Controls.Add(this.LBLdataL);
            this.Controls.Add(this.TXTisbnL);
            this.Controls.Add(this.LBLisbnL);
            this.Controls.Add(this.TXTlinguaL);
            this.Controls.Add(this.LBLlingua);
            this.Controls.Add(this.TXTanoL);
            this.Controls.Add(this.LBLanoL);
            this.Controls.Add(this.TXTtiltuloL);
            this.Controls.Add(this.LBLtituloL);
            this.Controls.Add(this.LBLcadL);
            this.Name = "CadLivro";
            this.Text = "CadLivro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcadL;
        private System.Windows.Forms.TextBox TXTdataL;
        private System.Windows.Forms.Label LBLdataL;
        private System.Windows.Forms.TextBox TXTisbnL;
        private System.Windows.Forms.Label LBLisbnL;
        private System.Windows.Forms.TextBox TXTlinguaL;
        private System.Windows.Forms.Label LBLlingua;
        private System.Windows.Forms.TextBox TXTanoL;
        private System.Windows.Forms.Label LBLanoL;
        private System.Windows.Forms.TextBox TXTtiltuloL;
        private System.Windows.Forms.Label LBLtituloL;
        private System.Windows.Forms.Label LBLcadL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltaralu2;
    }
}