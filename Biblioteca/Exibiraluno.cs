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
    public partial class Exibiraluno : Form
    {
        public Exibiraluno()
        {
            InitializeComponent();
        }

        private void voltaralu1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Dispose();
            menu.ShowDialog();
        }

        private void Exibiraluno_Load(object sender, EventArgs e)
        {

        }

        private void txtpesquisaraluno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
