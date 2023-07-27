using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public partial class ConsultaEditora : Form
    {
        public ConsultaEditora()
        {
            InitializeComponent();
            PopularDgv();
        }

        void PopularDgv() 
        {
            //var sql = new ComandoSQL();
            //var editoras = sql.ConsultaEditora();

            var editoras = new List<Editora>();

            editoras.Add(new Editora { Id = 1, Nome = "Teste 1", Pais = "Brasil" });
            editoras.Add(new Editora { Id = 2, Nome = "Teste 2", Pais = "Brasil" });
            editoras.Add(new Editora { Id = 3, Nome = "Teste 3", Pais = "Brasil" });
            editoras.Add(new Editora { Id = 4, Nome = "Teste 4", Pais = "Argentina" });

            dgvConsultaEdit.DataSource = editoras.ToList();
        }

        private void btnConsulSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
