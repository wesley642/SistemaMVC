using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Entidades;
using View.DAO;
using View.Modelo;

namespace View
{
    public partial class CadTelefone : Form
    {
        public CadTelefone()
        {
            InitializeComponent();
        }

        UsuarioEnt objTabela = new UsuarioEnt(); // pode pegar todos os dados do usuario ent

        private void LimparCampos()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtNome.Focus();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {

            objTabela.Nome = txtNome.Text;
            objTabela.Telefone = txtTelefone.Text;

            int x = UsuarioModelo.Inserir(objTabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Usuario ' {0} ' foi inserido com súcesso!", txtNome.Text));
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
            }
            LimparCampos();
            ListarGrid();
        }



        private void ListarGrid()
        {
            try
            {
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                lista = new UsuarioModelo().Lista();
                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadTelefone_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void grid_cellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtID.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[2].Value.ToString();

        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text == "")
            {
                ListarGrid();
                return;
            }
            try
            {
                LimparCampos();
                txtConsulta.Focus();
                objTabela.Nome = txtConsulta.Text;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                lista = new UsuarioModelo().Consulta(objTabela);

                grid.AutoGenerateColumns = false;
                grid.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar dados!" + ex.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                objTabela.Id = Convert.ToInt32(txtID.Text);
                objTabela.Nome = Convert.ToString(txtNome.Text);
                objTabela.Telefone = Convert.ToString(txtTelefone.Text);

                int x = UsuarioModelo.Alterar(objTabela);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("O usuario {0} foi editado com sucesso!", txtNome.Text));
                }
                else
                {
                    MessageBox.Show("Usuario inalterado");

                }
                LimparCampos();
                ListarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objTabela.Id = Convert.ToInt32(txtID.Text);
                objTabela.Nome = Convert.ToString(txtNome.Text);
                objTabela.Telefone = Convert.ToString(txtTelefone.Text);

                int x = UsuarioModelo.Deletar(objTabela);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("O usuario {0} foi deletado com sucesso!", txtNome.Text));
                }
                else
                {
                    MessageBox.Show("Usuario não foi deletado");

                }
                LimparCampos();
                ListarGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
