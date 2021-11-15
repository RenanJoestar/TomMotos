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
    public partial class Fmrfuncionario : Form
    {
        static string nome, idUser, id_cargo;
        MySqlConnection conexao = ConnectionFactory.getConnection();
        public Fmrfuncionario()
        {
            InitializeComponent();

        }

     

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioModel obj = new FuncionarioModel();

                obj.id = int.Parse(txt_id.Text);
                if (txt_nome.Text == "") obj.nome = null;
                else obj.nome = txt_nome.Text.ToUpper();
                if (txt_sobrenome.Text == "") obj.sobrenome = null; 
                else obj.sobrenome = txt_sobrenome.Text.ToUpper();
                obj.data_nasc = txt_nascimento.Text.ToUpper();
                obj.cpf = txt_cpf.Text.ToUpper();
                obj.sexo = cbx_sexo.Text.ToUpper();
                string select = "select id_cargo from tb_cargo where nome_cargo = " + "'" + cbxCargos.Text.ToString() + "'";
                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                
                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    id_cargo = ds.Tables[0].Rows[0]["id_cargo"].ToString();

                    obj.cargo_fk = id_cargo;
                }
               
                obj.data_contratacao = txt_contratacao.Text.ToUpper();

                FuncionarioDAO Cadastro = new FuncionarioDAO();

                Cadastro.cadastrarFuncionario(obj);
               
                dg_funcionario.DataSource = Cadastro.ListarTodosFuncionario();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void Fmrfuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO Cadastro = new FuncionarioDAO();
            dg_funcionario.DataSource = Cadastro.ListarTodosFuncionario();
            FuncionarioDAO Showcargo = new FuncionarioDAO();
            
            carregarCargo();

        } 

       
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
             try
            {
                FuncionarioModel obj = new FuncionarioModel();
                obj.id = int.Parse(txt_id.Text);                
                if (txt_nome.Text == "") obj.nome = null;
                else obj.nome = txt_nome.Text.ToUpper();
                if (txt_sobrenome.Text == "") obj.sobrenome = null;
                else obj.sobrenome = txt_sobrenome.Text.ToUpper();
                obj.data_nasc = txt_nascimento.Text.ToUpper();
                obj.cpf = txt_cpf.Text.ToUpper();
                obj.sexo = cbx_sexo.Text.ToUpper(); 
                    string select = "select id_cargo from tb_cargo where nome_cargo = " + "'" + cbxCargos.Text.ToString() + "'";
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        id_cargo = ds.Tables[0].Rows[0]["id_cargo"].ToString();

                        obj.cargo_fk = id_cargo;
                    }
                    obj.data_contratacao = txt_contratacao.Text.ToUpper();

                FuncionarioDAO dao = new FuncionarioDAO();
                dao.alterar(obj);
                dg_funcionario.DataSource = dao.ListarTodosFuncionario();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }
            }
            else MessageBox.Show("Escolha um id que deseja Alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dg_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_funcionario.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_funcionario.CurrentRow.Cells[1].Value.ToString();
            txt_sobrenome.Text = dg_funcionario.CurrentRow.Cells[2].Value.ToString();
            txt_nascimento.Text = dg_funcionario.CurrentRow.Cells[4].Value.ToString();
            txt_cpf.Text = dg_funcionario.CurrentRow.Cells[3].Value.ToString();
            cbx_sexo.Text = dg_funcionario.CurrentRow.Cells[6].Value.ToString();           
            string fk_cargo = dg_funcionario.CurrentRow.Cells[7].Value.ToString();
            if (fk_cargo != "") { 
            string select = "select nome_cargo, id_funcionario from tb_funcionario inner join tb_cargo on tb_cargo.id_cargo = tb_funcionario.fk_cargo_id where id_funcionario = " + fk_cargo;
            MySqlCommand executacmdsql = new MySqlCommand(select, conexao);

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataSet ds = new DataSet();
            da.Fill(ds);
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                string nome_cargo = ds.Tables[0].Rows[0]["nome_cargo"].ToString();

                cbxCargos.Text = nome_cargo.ToString();
             }
            }
            else cbxCargos.Text = "";

            txt_contratacao.Text = dg_funcionario.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                var result = MessageBox.Show("Deseja excluir o Funcionario " + txt_nome.Text + "?", "EXCLUIR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        FuncionarioModel obj = new FuncionarioModel();
                        obj.id = int.Parse(txt_id.Text);


                        FuncionarioDAO dao = new FuncionarioDAO();
                        dao.Excluir(obj);
                        dg_funcionario.DataSource = dao.ListarTodosFuncionario();
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE EMAIL DO FUNCIONARIO " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_funcionario_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    //conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                        EmailModel.id = idUser;
                    }
                    //conexao.Close();
                    
                    Fmremail nomeFuncionario= new Fmremail(nome);
                    nomeFuncionario.Show();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.ToString());
                }

            }
            else
            {
                MessageBox.Show("Escolha um Funcionario que deseja cadastrar o email", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE ENDEREÇO DO FUNCIONARIO " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_funcionario_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                   // conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                        EnderecoModel.id = idUser;
                    }
                    //conexao.Close();
                    

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
                MessageBox.Show("Escolha um Funcionario que deseja cadastrar o endereco", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Fmrfuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cbxBuscar.Text.ToString()+"_funcionario" ;
                FiltroModel.filtro = @"select * from tb_funcionario where " + campo.ToLower()+ " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                //MessageBox.Show("Test "+ FiltroModel.filtro);
                FiltroDAO dao = new FiltroDAO();
                dg_funcionario.DataSource = dao.buscaCargo();               
             
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }

        private void dg_funcionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE TELEFONE DO FUNCIONARIO " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_funcionario_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    //conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                        TelefoneModel.id = idUser;
                    }
                   // conexao.Close();
                    

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
                MessageBox.Show("Escolha um Funcionario que deseja cadastrar o telefone", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void carregarCargo() {

            MySqlConnection cn = new MySqlConnection();
            cn = conexao;            
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "select id_cargo, nome_cargo from tb_cargo";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbxCargos.DisplayMember = "nome_cargo";
            cbxCargos.DataSource = dt;
            cbxCargos.Text = null;
        }
     }
}
