namespace Biblioteca
{
    partial class CadEmprestimo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltaralu2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltaralu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltaralu2
            // 
            this.voltaralu2.Name = "voltaralu2";
            this.voltaralu2.Size = new System.Drawing.Size(49, 20);
            this.voltaralu2.Text = "Voltar";
            // 
            // BTNcadL
            // 
            this.BTNcadL.Location = new System.Drawing.Point(148, 264);
            this.BTNcadL.Name = "BTNcadL";
            this.BTNcadL.Size = new System.Drawing.Size(75, 23);
            this.BTNcadL.TabIndex = 37;
            this.BTNcadL.Text = "Cadastrar";
            this.BTNcadL.UseVisualStyleBackColor = true;
            this.BTNcadL.Click += new System.EventHandler(this.BTNcadL_Click_1);
            // 
            // TXTdataL
            // 
            this.TXTdataL.Location = new System.Drawing.Point(186, 224);
            this.TXTdataL.Name = "TXTdataL";
            this.TXTdataL.Size = new System.Drawing.Size(100, 20);
            this.TXTdataL.TabIndex = 36;
            // 
            // LBLdataL
            // 
            this.LBLdataL.AutoSize = true;
            this.LBLdataL.Location = new System.Drawing.Point(68, 227);
            this.LBLdataL.Name = "LBLdataL";
            this.LBLdataL.Size = new System.Drawing.Size(112, 13);
            this.LBLdataL.TabIndex = 35;
            this.LBLdataL.Text = "Data para Devolução:";
            // 
            // TXTisbnL
            // 
            this.TXTisbnL.Location = new System.Drawing.Point(186, 195);
            this.TXTisbnL.Name = "TXTisbnL";
            this.TXTisbnL.Size = new System.Drawing.Size(100, 20);
            this.TXTisbnL.TabIndex = 34;
            // 
            // LBLisbnL
            // 
            this.LBLisbnL.AutoSize = true;
            this.LBLisbnL.Location = new System.Drawing.Point(75, 198);
            this.LBLisbnL.Name = "LBLisbnL";
            this.LBLisbnL.Size = new System.Drawing.Size(105, 13);
            this.LBLisbnL.TabIndex = 33;
            this.LBLisbnL.Text = "Data do Emprestimo:";
            // 
            // TXTlinguaL
            // 
            this.TXTlinguaL.Location = new System.Drawing.Point(186, 162);
            this.TXTlinguaL.Name = "TXTlinguaL";
            this.TXTlinguaL.Size = new System.Drawing.Size(100, 20);
            this.TXTlinguaL.TabIndex = 32;
            // 
            // LBLlingua
            // 
            this.LBLlingua.AutoSize = true;
            this.LBLlingua.Location = new System.Drawing.Point(117, 165);
            this.LBLlingua.Name = "LBLlingua";
            this.LBLlingua.Size = new System.Drawing.Size(63, 13);
            this.LBLlingua.TabIndex = 31;
            this.LBLlingua.Text = "ID do ADM:";
            // 
            // TXTanoL
            // 
            this.TXTanoL.Location = new System.Drawing.Point(186, 129);
            this.TXTanoL.Name = "TXTanoL";
            this.TXTanoL.Size = new System.Drawing.Size(100, 20);
            this.TXTanoL.TabIndex = 30;
            // 
            // LBLanoL
            // 
            this.LBLanoL.AutoSize = true;
            this.LBLanoL.Location = new System.Drawing.Point(108, 132);
            this.LBLanoL.Name = "LBLanoL";
            this.LBLanoL.Size = new System.Drawing.Size(72, 13);
            this.LBLanoL.TabIndex = 29;
            this.LBLanoL.Text = "RM do Aluno:";
            this.LBLanoL.Click += new System.EventHandler(this.LBLanoL_Click_1);
            // 
            // TXTtiltuloL
            // 
            this.TXTtiltuloL.Location = new System.Drawing.Point(186, 93);
            this.TXTtiltuloL.Name = "TXTtiltuloL";
            this.TXTtiltuloL.Size = new System.Drawing.Size(100, 20);
            this.TXTtiltuloL.TabIndex = 28;
            // 
            // LBLtituloL
            // 
            this.LBLtituloL.AutoSize = true;
            this.LBLtituloL.Location = new System.Drawing.Point(133, 96);
            this.LBLtituloL.Name = "LBLtituloL";
            this.LBLtituloL.Size = new System.Drawing.Size(47, 13);
            this.LBLtituloL.TabIndex = 27;
            this.LBLtituloL.Text = "ID Livro:";
            // 
            // LBLcadL
            // 
            this.LBLcadL.AutoSize = true;
            this.LBLcadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LBLcadL.Location = new System.Drawing.Point(105, 41);
            this.LBLcadL.Name = "LBLcadL";
            this.LBLcadL.Size = new System.Drawing.Size(181, 25);
            this.LBLcadL.TabIndex = 26;
            this.LBLcadL.Text = "Novo Emprestimo";
            // 
            // CadEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 356);
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
            this.Name = "CadEmprestimo";
            this.Text = "CadEmprestimo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltaralu2;
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
    }
}