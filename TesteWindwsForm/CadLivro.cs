using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Consultas
{
    public partial class CadLivro : Form
    {
        private string strSQL = (@"Server=NOTE-DELL\AMGSQL;Database=Biblioteca;User Id=sa;Password=anz235..");

        public CadLivro()
        {
            InitializeComponent();

            
    }

        private void CadLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet1.autor'. Você pode movê-la ou removê-la conforme necessário.
            this.autorTableAdapter.Fill(this.bibliotecaDataSet1.autor);
            // TODO: esta linha de código carrega dados na tabela 'bibliotecaDataSet.autor'. Você pode movê-la ou removê-la conforme necessário.
            this.autorTableAdapter.Fill(this.bibliotecaDataSet.autor);
            txtIdLivro.Enabled = false;
        }

        private void cbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            SqlConnection conn = new SqlConnection(strSQL);

            SqlDataAdapter da = new SqlDataAdapter("select sobrenome_autor, nome_autor from autor order by sobrenome_autor", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cbAutor.DataSource = dt;
            cbAutor.DisplayMember = "ItemName";
            cbAutor.ValueMember = "ItemName";


            /*da.Fill(dt);
            cbxparameter.DataSource = dt;
            cbxparameter.DisplayMember = "ItemName";
            cbxparameter.ValueMember = "ItemName";
            */



        }

        private void fillBy_autorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.autorTableAdapter.FillBy_autor(this.bibliotecaDataSet.autor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbAutor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            datatab
        }
    }
}
