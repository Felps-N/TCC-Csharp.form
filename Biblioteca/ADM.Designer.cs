namespace Biblioteca
{
    partial class ADM
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblAluno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAdiminstrador = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.TextBox();
            this.LBLcadL = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(195, 274);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(99, 29);
            this.btnConfirmar.TabIndex = 36;
            this.btnConfirmar.Text = "Cadastrar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(90, 199);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(35, 13);
            this.lblAluno.TabIndex = 33;
            this.lblAluno.Text = "E-mail";
            this.lblAluno.Click += new System.EventHandler(this.lblAluno_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 32;
            // 
            // lblAdiminstrador
            // 
            this.lblAdiminstrador.AutoSize = true;
            this.lblAdiminstrador.Location = new System.Drawing.Point(90, 159);
            this.lblAdiminstrador.Name = "lblAdiminstrador";
            this.lblAdiminstrador.Size = new System.Drawing.Size(35, 13);
            this.lblAdiminstrador.TabIndex = 31;
            this.lblAdiminstrador.Text = "Nome";
            this.lblAdiminstrador.UseMnemonic = false;
            this.lblAdiminstrador.Click += new System.EventHandler(this.lblAdiminstrador_Click);
            // 
            // lblLivro
            // 
            this.lblLivro.Location = new System.Drawing.Point(195, 153);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(203, 20);
            this.lblLivro.TabIndex = 30;
            // 
            // LBLcadL
            // 
            this.LBLcadL.AutoSize = true;
            this.LBLcadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LBLcadL.Location = new System.Drawing.Point(177, 79);
            this.LBLcadL.Name = "LBLcadL";
            this.LBLcadL.Size = new System.Drawing.Size(152, 25);
            this.LBLcadL.TabIndex = 37;
            this.LBLcadL.Text = "Cadastro ADM";
            this.LBLcadL.Click += new System.EventHandler(this.LBLcadL_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 38;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Senha";
            // 
            // ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LBLcadL);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAdiminstrador);
            this.Controls.Add(this.lblLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADM";
            this.Text = "ADM";
            this.Load += new System.EventHandler(this.ADM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAdiminstrador;
        private System.Windows.Forms.TextBox lblLivro;
        private System.Windows.Forms.Label LBLcadL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}