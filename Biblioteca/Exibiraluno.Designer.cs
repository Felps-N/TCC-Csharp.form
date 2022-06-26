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
            this.lbltituloaluno2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpesquisaraluno
            // 
            this.txtpesquisaraluno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpesquisaraluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtpesquisaraluno.Location = new System.Drawing.Point(181, 74);
            this.txtpesquisaraluno.Name = "txtpesquisaraluno";
            this.txtpesquisaraluno.Size = new System.Drawing.Size(167, 23);
            this.txtpesquisaraluno.TabIndex = 80;
            this.txtpesquisaraluno.Text = "Digite o Nome do Aluno";
            this.txtpesquisaraluno.TextChanged += new System.EventHandler(this.txtpesquisaraluno_TextChanged);
            // 
            // lbltituloaluno2
            // 
            this.lbltituloaluno2.AutoSize = true;
            this.lbltituloaluno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.3F);
            this.lbltituloaluno2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbltituloaluno2.Location = new System.Drawing.Point(181, 36);
            this.lbltituloaluno2.Name = "lbltituloaluno2";
            this.lbltituloaluno2.Size = new System.Drawing.Size(171, 26);
            this.lbltituloaluno2.TabIndex = 147;
            this.lbltituloaluno2.Text = "Consulta Alunos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 283);
            this.dataGridView1.TabIndex = 148;
            // 
            // Exibiraluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltituloaluno2);
            this.Controls.Add(this.txtpesquisaraluno);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exibiraluno";
            this.Text = "Exibiraluno";
            this.TransparencyKey = System.Drawing.Color.FloralWhite;
            this.Load += new System.EventHandler(this.Exibiraluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtpesquisaraluno;
        private System.Windows.Forms.Label lbltituloaluno2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}