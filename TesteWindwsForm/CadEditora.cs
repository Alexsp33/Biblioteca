using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CadEditora : Form
    
    {
    
        string conexao = (@"Server=NOTE-DELL\AMGSQL;Database=Biblioteca;User Id=sa;Password=anz235..");

        public CadEditora()
        {
            InitializeComponent();

            DesabilitaCampo();

        }

        private void DesabilitaCampo()
        {
            txtIDEditora.Enabled = true;
            comboBox1.Enabled = false;
            txtNomeEditora.Enabled = false;
            btnSalvarEdit.Visible = false;
            btnListarEdit.Enabled = true;
            btnNovoEdit.Visible = true;
            btnConsultar.Visible = true;
            label3.Visible = true;
            txtIDEditora.Visible = true;
            btnAtualizar.Visible = false;
        }
        private void HabilitaCampo()
        {
            label3.Visible = false;
            txtIDEditora.Visible = false;
            comboBox1.Enabled = true;
            txtNomeEditora.Enabled = true;
            btnSalvarEdit.Visible = true;
            btnListarEdit.Enabled = false;
            btnNovoEdit.Visible = false;
            btnConsultar.Visible = false;
        }



        private void btnSalvarEdit_Click(object sender, EventArgs e)
        {

            if (txtNomeEditora.Text.Length > 1)
            {


                ComandoSQL editora = new ComandoSQL();

                editora.AdicionarEditora(txtNomeEditora.Text, comboBox1.Text);

                MessageBox.Show("Editora gravada com sucesso");

                txtNomeEditora.Clear();



                DesabilitaCampo();
            }
            else
            {
                MessageBox.Show("Não é possivel gravar a editora, favor inserir mais caracteres");
            }        
        }

        
        private void btnAtivEdit_Click(object sender, EventArgs e)
        {
            HabilitaCampo();

        }

        private void btnConsultaEdit_Click(object sender, EventArgs e)
        {
            ConsultaEditora ce = new ConsultaEditora();
            ce.Show();

            
            string strSQL = "SELECT id_editora as 'ID EDITORA', nome_editora as 'NOME EDITORA', pais as 'PAÍS'  FROM editora";

            try
            {
                SqlConnection conn = new SqlConnection(conexao);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, conn);

                conn.Open();

                da.Fill(ds);

                
                ce.dgvConsultaEdit.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            

            if (txtIDEditora.Text.Length == 0)
            {
                MessageBox.Show("Digite um numero para consultar");
            }
            else
            {
                txtNomeEditora.Enabled = true;
                comboBox1.Enabled = true;
                btnAtualizar.Visible = true;

                try
                {

                    string strSQL = "SELECT * FROM editora WHERE id_editora = @ID";

                    SqlDataReader dr;

                    SqlConnection conn = new SqlConnection(conexao);

                    SqlCommand comando = new SqlCommand(strSQL, conn);

                    comando.Parameters.AddWithValue("@ID", txtIDEditora.Text);

                    conn.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        txtIDEditora.Text = Convert.ToString(dr["id_editora"]);
                        txtNomeEditora.Text = (string)dr["nome_editora"];
                        comboBox1.Text = (string)dr["pais"];

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Editora nao contem o País Cadastrado, favor informar.");
                }
                finally
                {

                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNomeEditora.Text.Length > 1)
            {


                ComandoSQL atuaeEditora = new ComandoSQL();

                atuaeEditora.AtualizaEditora(int.Parse(txtIDEditora.Text), txtNomeEditora.Text, comboBox1.Text);

                MessageBox.Show("Editora gravada com sucesso");

                txtNomeEditora.Clear();



                DesabilitaCampo();
            }
            else
            {
                MessageBox.Show("Não é possivel gravar a editora, favor inserir mais caracteres");
            }
        }

       
    }
    
}
