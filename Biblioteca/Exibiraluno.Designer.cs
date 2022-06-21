namespace Biblioteca
{
    partial class Exibiraluno
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
            this.txtpesquisaraluno = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltaralu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbltituloaluno2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisaraluno
            // 
            this.txtpesquisaraluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpesquisaraluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtpesquisaraluno.Location = new System.Drawing.Point(155, 74);
            this.txtpesquisaraluno.Name = "txtpesquisaraluno";
            this.txtpesquisaraluno.Size = new System.Drawing.Size(167, 23);
            this.txtpesquisaraluno.TabIndex = 80;
            this.txtpesquisaraluno.Text = "Digite o Nome do Aluno";
            this.txtpesquisaraluno.TextChanged += new System.EventHandler(this.txtpesquisaraluno_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltaralu1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 106;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltaralu1
            // 
            this.voltaralu1.Name = "voltaralu1";
            this.voltaralu1.Size = new System.Drawing.Size(49, 20);
            this.voltaralu1.Text = "Voltar";
            this.voltaralu1.Click += new System.EventHandler(this.voltaralu1_Click);
            // 
            // lbltituloaluno2
            // 
            this.lbltituloaluno2.AutoSize = true;
            this.lbltituloaluno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3F);
            this.lbltituloaluno2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbltituloaluno2.Location = new System.Drawing.Point(155, 36);
            this.lbltituloaluno2.Name = "lbltituloaluno2";
            this.lbltituloaluno2.Size = new System.Drawing.Size(171, 26);
            this.lbltituloaluno2.TabIndex = 147;
            this.lbltituloaluno2.Text = "Consulta Alunos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 283);
            this.dataGridView1.TabIndex = 148;
            // 
            // Exibiraluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltituloaluno2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtpesquisaraluno);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Exibiraluno";
            this.Text = "Exibiraluno";
            this.TransparencyKey = System.Drawing.Color.FloralWhite;
            this.Load += new System.EventHandler(this.Exibiraluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisaraluno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltaralu1;
        private System.Windows.Forms.Label lbltituloaluno2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}