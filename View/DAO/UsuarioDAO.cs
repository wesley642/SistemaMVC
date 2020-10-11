using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Entidades;
using View.Modelo;
using System.Data;
using System.Data.SqlClient;
using View.DAO;
using System.Windows.Forms;

namespace View.DAO
{
    class UsuarioDAO
    {
        internal int Inserir(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "INSERT INTO cadtelefone (nome,telefone) VALUES (@nome, @telefone)";

                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("telefone", System.Data.SqlDbType.VarChar).Value = objTabela.Telefone;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }

        internal int Deletar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM cadtelefone WHERE id=@id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("telefone", System.Data.SqlDbType.VarChar).Value = objTabela.Telefone;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        internal int Alterar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "Update cadtelefone SET nome=@nome, telefone=@telefone WHERE id=@id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("telefone", System.Data.SqlDbType.VarChar).Value = objTabela.Telefone;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public List<UsuarioEnt> Consulta(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM cadtelefone WHERE nome LIKE @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        lista.Add(dado);
                    }

                }
                return lista;
            }
        }

        internal List<UsuarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM cadtelefone";
                cn.Connection = con;
                SqlDataReader dr;

                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);

                        lista.Add(dado);
                    }

                }
                return lista;
            }
        }
    }
}
