using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Consultas;

namespace WindowsFormsApplication1
{
    public partial class TelaSistema : Form
    {
        public TelaSistema()
        {
            InitializeComponent();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadLivro livro1 = new CadLivro();
            livro1.Show();

            

        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadAutor autor1 = new CadAutor();
            autor1.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEditora cadedit1 = new CadEditora();
            cadedit1.Show();
        }
    }
}
