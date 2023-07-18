using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class CadAutor : Form
    {
        public CadAutor()
        {
            InitializeComponent();
        }

        private void btnSalvarAutor_Click(object sender, EventArgs e)
        {
            ComandoSQL c1 = new ComandoSQL();
            c1.AdicionarAutor(txtAutorNome.Text, txtAutorSobren.Text);

            MessageBox.Show("Dados Gravados com Sucesso");
        }
    }
}
