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
    public partial class Fmrtelefone : Form
    {
        TelefoneDAO Cadastro = new TelefoneDAO();
        FiltroDAO Filtro = new FiltroDAO();
        public Fmrtelefone()
        {
            InitializeComponent();
        }
        public Fmrtelefone(string NOME)
        {
            InitializeComponent();
            lblNome.Text = NOME;

        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
      

        private void Fmrtelefone_Load(object sender, EventArgs e)
        {
            dgTelefone.DataSource = Cadastro.ListarTelefones();
            txt_id.Text = TelefoneModel.id;
        }


        private void Fmrtelefone_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Test");
            TelefoneModel.id = null;
            TelefoneModel.id_telefone = null;
        }

        private void Fmrtelefone_Activated(object sender, EventArgs e)
        {
            TelefoneDAO Cadastro = new TelefoneDAO();
            dgTelefone.DataSource = Cadastro.ListarTelefones();
            txt_id.Text = TelefoneModel.id;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                TelefoneModel obj = new TelefoneModel();
                TelefoneModel.id = txt_id.Text;
                if (txt_telefone.Text != "(  )      -     ")
                    obj.nome = txt_telefone.Text.ToUpper();
                else return;         
                TelefoneDAO Cadastro = new TelefoneDAO();

                Cadastro.cadastrarTelefone(obj);

                dgTelefone.DataSource = Cadastro.ListarTelefones();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TelefoneModel obj = new TelefoneModel();
                
                obj.nome = txt_telefone.Text.ToUpper();

                TelefoneDAO Alterar = new TelefoneDAO();

                Alterar.alterar(obj);

                dgTelefone.DataSource = Alterar.ListarTelefones();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TelefoneModel obj = new TelefoneModel();

                obj.nome = txt_telefone.Text.ToUpper();

                TelefoneDAO Excluir = new TelefoneDAO();

                Excluir.Excluir(obj);

                dgTelefone.DataSource = Excluir.ListarTelefones();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBuscar.Text != "")
                {
                    string campo = cbxBuscar.Text.ToString();
                    string finalSQL = "";

                    if (campo == "ID") campo = "tb_telefone.id_telefone";
                    if (campo == "NÚMERO") campo = "tb_telefone.numero_telefone";
                    finalSQL += campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";

                    FiltroModel.campoWhere = finalSQL;

                    dgTelefone.DataSource = Filtro.buscaTelefone();
                }
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro.Message); }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void dgTelefone_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string idTel = dgTelefone.CurrentRow.Cells[0].Value.ToString();
            txt_telefone.Text = dgTelefone.CurrentRow.Cells[1].Value.ToString();
            TelefoneModel.id_telefone = idTel;
        }

        private void cbxBuscar_DropDown(object sender, EventArgs e)
        {

        }

        private void cbxBuscar_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btnMostrarTudo_Click(object sender, EventArgs e)
        {
            dgTelefone.DataSource = Cadastro.ListarTelefones();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
