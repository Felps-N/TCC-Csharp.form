namespace Biblioteca
{
    partial class ExibirLivro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltituloaluno2 = new System.Windows.Forms.Label();
            this.txtpesquisaraluno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 282);
            this.dataGridView1.TabIndex = 151;
            // 
            // lbltituloaluno2
            // 
            this.lbltituloaluno2.AutoSize = true;
            this.lbltituloaluno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3F);
            this.lbltituloaluno2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbltituloaluno2.Location = new System.Drawing.Point(180, 37);
            this.lbltituloaluno2.Name = "lbltituloaluno2";
            this.lbltituloaluno2.Size = new System.Drawing.Size(169, 26);
            this.lbltituloaluno2.TabIndex = 150;
            this.lbltituloaluno2.Text = "Consultar Livros";
            // 
            // txtpesquisaraluno
            // 
            this.txtpesquisaraluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpesquisaraluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtpesquisaraluno.Location = new System.Drawing.Point(180, 75);
            this.txtpesquisaraluno.Name = "txtpesquisaraluno";
            this.txtpesquisaraluno.Size = new System.Drawing.Size(167, 23);
            this.txtpesquisaraluno.TabIndex = 149;
            this.txtpesquisaraluno.Text = "Digite o Nome do Livro";
            // 
            // ExibirLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltituloaluno2);
            this.Controls.Add(this.txtpesquisaraluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExibirLivro";
            this.Text = "ExibirLivro";
            this.Load += new System.EventHandler(this.ExibirLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltituloaluno2;
        private System.Windows.Forms.TextBox txtpesquisaraluno;
    }
}