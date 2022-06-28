using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAluno calu = new CadAluno();
            /*this.Dispose();
            calu.ShowDialog();*/
            OpenExibirform(calu);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Dispose();
            form.ShowDialog();

        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Exibiraluno ealu = new Exibiraluno();
            this.Dispose();
            ealu.ShowDialog();*/
            OpenExibirform(new Exibiraluno());
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadLivro cliv = new CadLivro();
            /*this.Dispose();
            cliv.ShowDialog();*/
            OpenExibirform(cliv);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pnlExibir_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenExibirform(object exibirform)
        {
            if (this.ExibirPnl.Controls.Count > 0)
                this.ExibirPnl.Controls.RemoveAt(0);
            Form ef = exibirform as Form;
            ef.TopLevel = false;
            ef.Dock = DockStyle.Fill;
            this.ExibirPnl.Controls.Add(ef);
            this.ExibirPnl.Tag = ef;
            ef.Show();
        }

        private void exibirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenExibirform(new ExibirLivro());
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenExibirform(new CadEmprestimo());
        }

        private void exibirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenExibirform(new ExibirEmprestimo());
        }

        private void aDMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExibirform(new ADM());
        }
    }
}