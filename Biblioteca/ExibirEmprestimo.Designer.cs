namespace Biblioteca
{
    partial class ExibirEmprestimo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltituloaluno2 = new System.Windows.Forms.Label();
            this.txtpesquisaraluno = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltaralu2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 152;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltaralu2
            // 
            this.voltaralu2.Name = "voltaralu2";
            this.voltaralu2.Size = new System.Drawing.Size(49, 20);
            this.voltaralu2.Text = "Voltar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 285);
            this.dataGridView1.TabIndex = 155;
            // 
            // lbltituloaluno2
            // 
            this.lbltituloaluno2.AutoSize = true;
            this.lbltituloaluno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3F);
            this.lbltituloaluno2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbltituloaluno2.Location = new System.Drawing.Point(176, 40);
            this.lbltituloaluno2.Name = "lbltituloaluno2";
            this.lbltituloaluno2.Size = new System.Drawing.Size(169, 26);
            this.lbltituloaluno2.TabIndex = 154;
            this.lbltituloaluno2.Text = "Consultar Livros";
            // 
            // txtpesquisaraluno
            // 
            this.txtpesquisaraluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpesquisaraluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtpesquisaraluno.Location = new System.Drawing.Point(176, 78);
            this.txtpesquisaraluno.Name = "txtpesquisaraluno";
            this.txtpesquisaraluno.Size = new System.Drawing.Size(173, 23);
            this.txtpesquisaraluno.TabIndex = 153;
            this.txtpesquisaraluno.Text = "Digite o Nome do Livro";
            // 
            // ExibirEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 418);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltituloaluno2);
            this.Controls.Add(this.txtpesquisaraluno);
            this.Name = "ExibirEmprestimo";
            this.Text = "ExibirEmprestimo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltaralu2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltituloaluno2;
        private System.Windows.Forms.TextBox txtpesquisaraluno;
    }
}