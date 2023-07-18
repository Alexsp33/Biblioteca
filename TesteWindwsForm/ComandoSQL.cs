using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace WindowsFormsApplication1
{
    class ComandoSQL
    {
        private string strSQL = (@"Server=NOTE-DELL\AMGSQL;Database=Biblioteca;User Id=sa;Password=anz235..");




        public void AdicionarAutor(string autor, string sobrenome)
        {
            SqlConnection conn = new SqlConnection(strSQL);


            try
            {

               
                SqlCommand comando = new SqlCommand("INSERT INTO autor (nome_autor, sobrenome_autor) values (@autor, @sobrenome_autor)", conn);
                comando.Parameters.AddWithValue("@autor", autor);
                comando.Parameters.AddWithValue("@sobrenome_autor", sobrenome) ;


                conn.Open();
                comando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                conn.Close();
            }
           
           
        
        
        }

        public void AdicionarEditora(string nome_editora, string pais)
        {
            SqlConnection conn = new SqlConnection(strSQL);
            SqlCommand comando = new SqlCommand("INSERT INTO editora (nome_editora, pais) values (@nome_editora, @pais)", conn);

            try
            {

                comando.Parameters.AddWithValue("@nome_editora", nome_editora);
                comando.Parameters.AddWithValue("@pais", pais);

                conn.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
                
            }
        }



        /* public DataSet ConsultaEditora()
        {
            SqlConnection conn = new SqlConnection(strSQL);
            string strSelect = "SELECT * FROM editora";
            SqlDataAdapter da = new SqlDataAdapter(strSelect, strSQL);



            try
            {
                DataSet ds = new DataSet();

                conn.Open();

                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na consulta: ", ex.Message);
            }
            finally
            {
                conn.Close();
            }


         }*/

        /*public DataTable RetornaAutor()  //retorna autor para Combobox
        {
            SqlConnection conn = new SqlConnection(strSQL);

            SqlDataAdapter da = new SqlDataAdapter("select sobrenome_autor, nome_autor from autor order by sobrenome_autor", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt.



            // Comandos para executar o data table
            /*da.Fill(dt);
            cbxparameter.DataSource = dt;
            cbxparameter.DisplayMember = "ItemName";
            cbxparameter.ValueMember = "ItemName";
            */

        public void AtualizaEditora(int id_editora, string nome_editora, string pais)
        {
            SqlConnection conn = new SqlConnection(strSQL);
            SqlCommand comando = new SqlCommand("update editora set nome_editora = @nome_editora, pais = @pais where id_editora = @id_editora", conn);

            try
            {
                comando.Parameters.AddWithValue("@id_editora", id_editora);
                comando.Parameters.AddWithValue("@nome_editora", nome_editora);
                comando.Parameters.AddWithValue("@pais", pais);

                conn.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();

            }
        }
    }
}
