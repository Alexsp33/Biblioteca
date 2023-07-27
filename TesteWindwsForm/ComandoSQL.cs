using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public class ComandoSQL
    {
        private string strSQL = (@"Server=amgsolutions.ddns.net,32544;Database=Biblioteca;User Id=sistema;Password=anz102030");

        public void AdicionarAutor(string autor, string sobrenome)
        {
            SqlConnection conn = new SqlConnection(strSQL);

            try
            {
                SqlCommand comando = new SqlCommand("INSERT INTO autor (nome_autor, sobrenome_autor) values (@autor, @sobrenome_autor)", conn);
                comando.Parameters.AddWithValue("@autor", autor);
                comando.Parameters.AddWithValue("@sobrenome_autor", sobrenome);


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



        public IEnumerable<Editora> ConsultaEditora()
        {
            var editoras = new List<Editora>();

            using (var conn = new SqlConnection(strSQL))
            {
                string strSelect = "SELECT * FROM editora";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, strSQL);

                try
                {
                    DataSet ds = new DataSet();

                    conn.Open();

                    using (var reader = conn.CreateCommand().ExecuteReader())
                    {
                        while (!reader.Read())
                            continue;

                        var editora = new Editora
                        {
                            Id = (int)reader["Id"],
                            Nome = (string)reader["Nome"],
                            Pais = (string)reader["Pais"]
                        };

                        editoras.Add(editora);
                    }

                    return editoras;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro na consulta: ", ex.Message);
                    return null;
                }
            }
        }

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
