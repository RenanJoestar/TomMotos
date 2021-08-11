using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrfornecedor : Form
    {
        string idUser,nome;
        MySqlConnection conexao = ConnectionFactory.getConnection();
        public Fmrfornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorModel obj = new FornecedorModel();

                obj.nome = txt_nome.Text.ToUpper();
                if (txt_cnpj.Text == "") obj.cnpj = null;
                else obj.cnpj = txt_cnpj.Text.ToUpper();

                FornecedorDAO Cadastro = new FornecedorDAO();

                Cadastro.cadastrarFornecedor(obj);

                
                dg_fornecedor.DataSource = Cadastro.ListarTodosFornecedores();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }


        private void Fmrfornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO Cadastro = new FornecedorDAO();
           
            dg_fornecedor.DataSource = Cadastro.ListarTodosFornecedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
            
            try
            {
                FornecedorModel obj = new FornecedorModel();
                obj.id = int.Parse(txt_id.Text);
                obj.nome = txt_nome.Text.ToUpper();
                if (txt_cnpj.Text == "") obj.cnpj = null;
                else obj.cnpj = txt_cnpj.Text.ToUpper();

                FornecedorDAO dao = new FornecedorDAO();
                dao.alterar(obj);
                dg_fornecedor.DataSource = dao.ListarTodosFornecedores();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }
            }
            else MessageBox.Show("Escolha um id que deseja Alterar", "Erro",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dg_fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_fornecedor.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_fornecedor.CurrentRow.Cells[1].Value.ToString();
            txt_cnpj.Text = dg_fornecedor.CurrentRow.Cells[2].Value.ToString();
        }

        private void dg_fornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "") { 
            var result = MessageBox.Show("Deseja excluir o Fornecedor " + txt_nome.Text + "?", "EXCLUIR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    FornecedorModel obj = new FornecedorModel();
                    obj.id = int.Parse(txt_id.Text);

                    FornecedorDAO dao = new FornecedorDAO();
                    dao.Excluir(obj);
                    dg_fornecedor.DataSource = dao.ListarTodosFornecedores();
                    MessageBox.Show("Excluido com Sucesso!");
                }
                catch (Exception erro)
                {
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE EMAIL DO FORNECEDOR " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_fornecedor_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                        EmailModel.id = idUser;
                    }
                    
                    conexao.Close();
                    
                    Fmremail nomeCliente = new Fmremail(nome);
                    nomeCliente.Show();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }

            }
            else
            {
                MessageBox.Show("Escolha um Fornecedor que deseja cadastrar o email", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE ENDEREÇO DO FORNECEDOR " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_fornecedor_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                        EnderecoModel.id = idUser;
                    }
                    conexao.Close();
                    

                    Fmrendereco destino = new Fmrendereco(nome);
                    destino.Show();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ouve um Erro" + erro);
                }
            }
            else
            {
                MessageBox.Show("Escolha um Fornecedor que deseja cadastrar o endereco", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE TELEFONE DO FORNECEDOR " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_fornecedor_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                        TelefoneModel.id = idUser;
                    }
                    conexao.Close();
                    

                    Fmrtelefone destino = new Fmrtelefone(nome);
                    destino.Show();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Ouve um Erro" + erro);
                }
            }
            else
            {
                MessageBox.Show("Escolha um Fornecedor que deseja cadastrar o email", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
