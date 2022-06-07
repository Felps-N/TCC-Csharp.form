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
            this.LBLcadL = new System.Windows.Forms.Label();
            this.LBLtituloL = new System.Windows.Forms.Label();
            this.TXTtiltuloL = new System.Windows.Forms.TextBox();
            this.LBLanoL = new System.Windows.Forms.Label();
            this.TXTanoL = new System.Windows.Forms.TextBox();
            this.LBLlingua = new System.Windows.Forms.Label();
            this.TXTlinguaL = new System.Windows.Forms.TextBox();
            this.LBLisbnL = new System.Windows.Forms.Label();
            this.TXTisbnL = new System.Windows.Forms.TextBox();
            this.LBLdataL = new System.Windows.Forms.Label();
            this.TXTdataL = new System.Windows.Forms.TextBox();
            this.BTNcadL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLcadL
            // 
            this.LBLcadL.AutoSize = true;
            this.LBLcadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LBLcadL.Location = new System.Drawing.Point(234, 54);
            this.LBLcadL.Name = "LBLcadL";
            this.LBLcadL.Size = new System.Drawing.Size(193, 25);
            this.LBLcadL.TabIndex = 0;
            this.LBLcadL.Text = "Cadastro de Livros";
            // 
            // LBLtituloL
            // 
            this.LBLtituloL.AutoSize = true;
            this.LBLtituloL.Location = new System.Drawing.Point(283, 114);
            this.LBLtituloL.Name = "LBLtituloL";
            this.LBLtituloL.Size = new System.Drawing.Size(38, 13);
            this.LBLtituloL.TabIndex = 1;
            this.LBLtituloL.Text = "Título:";
            // 
            // TXTtiltuloL
            // 
            this.TXTtiltuloL.Location = new System.Drawing.Point(327, 111);
            this.TXTtiltuloL.Name = "TXTtiltuloL";
            this.TXTtiltuloL.Size = new System.Drawing.Size(100, 20);
            this.TXTtiltuloL.TabIndex = 2;
            // 
            // LBLanoL
            // 
            this.LBLanoL.AutoSize = true;
            this.LBLanoL.Location = new System.Drawing.Point(222, 150);
            this.LBLanoL.Name = "LBLanoL";
            this.LBLanoL.Size = new System.Drawing.Size(99, 13);
            this.LBLanoL.TabIndex = 3;
            this.LBLanoL.Text = "Ano de publicação:";
            // 
            // TXTanoL
            // 
            this.TXTanoL.Location = new System.Drawing.Point(327, 147);
            this.TXTanoL.Name = "TXTanoL";
            this.TXTanoL.Size = new System.Drawing.Size(100, 20);
            this.TXTanoL.TabIndex = 4;
            // 
            // LBLlingua
            // 
            this.LBLlingua.AutoSize = true;
            this.LBLlingua.Location = new System.Drawing.Point(277, 183);
            this.LBLlingua.Name = "LBLlingua";
            this.LBLlingua.Size = new System.Drawing.Size(44, 13);
            this.LBLlingua.TabIndex = 5;
            this.LBLlingua.Text = "Língua:";
            // 
            // TXTlinguaL
            // 
            this.TXTlinguaL.Location = new System.Drawing.Point(327, 180);
            this.TXTlinguaL.Name = "TXTlinguaL";
            this.TXTlinguaL.Size = new System.Drawing.Size(100, 20);
            this.TXTlinguaL.TabIndex = 6;
            // 
            // LBLisbnL
            // 
            this.LBLisbnL.AutoSize = true;
            this.LBLisbnL.Location = new System.Drawing.Point(286, 216);
            this.LBLisbnL.Name = "LBLisbnL";
            this.LBLisbnL.Size = new System.Drawing.Size(35, 13);
            this.LBLisbnL.TabIndex = 7;
            this.LBLisbnL.Text = "ISBN:";
            // 
            // TXTisbnL
            // 
            this.TXTisbnL.Location = new System.Drawing.Point(327, 213);
            this.TXTisbnL.Name = "TXTisbnL";
            this.TXTisbnL.Size = new System.Drawing.Size(100, 20);
            this.TXTisbnL.TabIndex = 8;
            // 
            // LBLdataL
            // 
            this.LBLdataL.AutoSize = true;
            this.LBLdataL.Location = new System.Drawing.Point(231, 245);
            this.LBLdataL.Name = "LBLdataL";
            this.LBLdataL.Size = new System.Drawing.Size(90, 13);
            this.LBLdataL.TabIndex = 9;
            this.LBLdataL.Text = "Data de Registro:";
            // 
            // TXTdataL
            // 
            this.TXTdataL.Location = new System.Drawing.Point(327, 242);
            this.TXTdataL.Name = "TXTdataL";
            this.TXTdataL.Size = new System.Drawing.Size(100, 20);
            this.TXTdataL.TabIndex = 10;
            // 
            // BTNcadL
            // 
            this.BTNcadL.Location = new System.Drawing.Point(289, 282);
            this.BTNcadL.Name = "BTNcadL";
            this.BTNcadL.Size = new System.Drawing.Size(75, 23);
            this.BTNcadL.TabIndex = 11;
            this.BTNcadL.Text = "Cadastrar";
            this.BTNcadL.UseVisualStyleBackColor = true;
            this.BTNcadL.Click += new System.EventHandler(this.BTNcadL_Click);
            // 
            // CadLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 492);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLcadL;
        private System.Windows.Forms.Label LBLtituloL;
        private System.Windows.Forms.TextBox TXTtiltuloL;
        private System.Windows.Forms.Label LBLanoL;
        private System.Windows.Forms.TextBox TXTanoL;
        private System.Windows.Forms.Label LBLlingua;
        private System.Windows.Forms.TextBox TXTlinguaL;
        private System.Windows.Forms.Label LBLisbnL;
        private System.Windows.Forms.TextBox TXTisbnL;
        private System.Windows.Forms.Label LBLdataL;
        private System.Windows.Forms.TextBox TXTdataL;
        private System.Windows.Forms.Button BTNcadL;
    }
}