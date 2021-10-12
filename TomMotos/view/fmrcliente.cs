using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TomMotos.Classes;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrcliente : Form
    {

        static string idUser, nome;
        MySqlConnection conexao = ConnectionFactory.getConnection();
        public Fmrcliente()
        {
            InitializeComponent();

        }

        private void fmrcliente_Load(object sender, EventArgs e)
        {
            ClienteDAO Cadastro = new ClienteDAO();


            dg_cliente.DataSource = Cadastro.ListarTodosClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteModel obj = new ClienteModel();

                obj.nome = txt_nome.Text.ToUpper();
                obj.sobrenome = txt_sobrenome.Text.ToUpper();

                if (txt_nascimento.Text == "") obj.data_nasc = null; // Verifica se a data de nascimento é null
                else obj.data_nasc = txt_nascimento.Text.ToUpper();

                if (txt_cpf.Text == "") obj.cpf = null;
                else obj.cpf = txt_cpf.Text.ToUpper();

                if (txt_cnpj.Text == "") obj.cnpj = null;  // É interessante perceber que isso não deve ser usado para alguns ints, por exemplo de quantidade tendo em vista
                else obj.cnpj = txt_cnpj.Text.ToUpper();             // que quantidade é um valor que não pode ser armazenado como nulo, se o produto não se encontra 
                                                                     // ele tem que ser cadastrado como 0.
                ClienteDAO Cadastro = new ClienteDAO();

                Cadastro.cadastrar(obj);


                dg_cliente.DataSource = Cadastro.ListarTodosClientes();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {

                try
                {
                    ClienteModel obj = new ClienteModel();
                    obj.id = int.Parse(txt_id.Text);
                    obj.nome = txt_nome.Text.ToUpper();
                    obj.sobrenome = txt_sobrenome.Text.ToUpper();

                    if (txt_nascimento.Text == "") obj.data_nasc = null; // Verifica se a data de nascimento é null
                    else obj.data_nasc = txt_nascimento.Text.ToUpper();

                    if (txt_cpf.Text == "") obj.cpf = null;
                    else obj.cpf = txt_cpf.Text.ToUpper();

                    if (txt_cnpj.Text == "") obj.cnpj = null;  // É interessante perceber que isso não deve ser usado para alguns ints, por exemplo de quantidade tendo em vista
                    else obj.cnpj = txt_cnpj.Text.ToUpper();

                    ClienteDAO dao = new ClienteDAO();
                    dao.alterar(obj);
                    dg_cliente.DataSource = dao.ListarTodosClientes();
                    MessageBox.Show("Alterado com Sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Aconteceu algum erro" + erro);
                }
            }
            else MessageBox.Show("Erro", "Escolha um id que deseja Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dg_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_cliente.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_cliente.CurrentRow.Cells[1].Value.ToString();
            txt_sobrenome.Text = dg_cliente.CurrentRow.Cells[2].Value.ToString();
            txt_nascimento.Text = dg_cliente.CurrentRow.Cells[3].Value.ToString();
            txt_cpf.Text = dg_cliente.CurrentRow.Cells[4].Value.ToString();
            txt_cnpj.Text = dg_cliente.CurrentRow.Cells[5].Value.ToString();

        }

        private void dg_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                var result = MessageBox.Show("Deseja excluir o cliente " + txt_nome.Text + "?", "EXCLUIR",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ClienteModel obj = new ClienteModel();
                        obj.id = int.Parse(txt_id.Text);

                        ClienteDAO dao = new ClienteDAO();
                        dao.Excluir(obj);
                        dg_cliente.DataSource = dao.ListarTodosClientes();
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
                    nome = ("CADASTRO DE EMAIL DO CLIENTE " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_cliente_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                    conexao.Close();
                    EmailModel.id = idUser;
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
                MessageBox.Show("Escolha um Cliente que deseja cadastrar o email", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {
                    nome = ("CADASTRO DE ENDEREÇO DO CLIENTE " + txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_cliente_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                    conexao.Close();
                    EnderecoModel.id = idUser;

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
                MessageBox.Show("Escolha um Cliente que deseja cadastrar o endereco", "Erro",
             MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Fmrcliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();

        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                string campo = cbxFiltrar.Text.ToString() + "_cliente";
                FiltroModel.filtro = @"select * from tb_cliente where " + campo.ToLower() + " like " + "'%" + txtFiltrar.Text.ToString() + "%'";
               // MessageBox.Show("Test " + FiltroModel.filtro);
                FiltroDAO dao = new FiltroDAO();
                dg_cliente.DataSource = dao.buscaCargo();

            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }



        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_cnpjs_TextChanged(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                try
                {

                    nome = ("CADASTRO DE TELEFONE DO CLIENTE "+txt_nome.Text).ToUpper();
                    string select = "select id_usuario from tb_usuario where fk_cliente_id =" + txt_id.Text;
                    MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                    conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    idUser = ds.Tables[0].Rows[0]["id_usuario"].ToString();
                    conexao.Close();

                    TelefoneModel.id = idUser;
                    Fmrtelefone nomeCliente = new Fmrtelefone(nome);
                    nomeCliente.Show();

                    
                    
                  




                }
                catch (Exception erro) {
                    MessageBox.Show(erro.ToString());
                }


            }
            else MessageBox.Show("Escolha um Cliente que deseja cadastrar o Telefone", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

    }
}
