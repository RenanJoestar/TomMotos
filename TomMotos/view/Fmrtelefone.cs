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

            TelefoneDAO Cadastro = new TelefoneDAO();
            dgTelefone.DataSource = Cadastro.ListarTelefones();
            txt_id.Text = TelefoneModel.id;

        }


        private void Fmrtelefone_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Test");
            TelefoneModel.id = null;
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
                obj.nome = txt_telefone.Text;
                         
                TelefoneDAO Cadastro = new TelefoneDAO();

                Cadastro.cadastrarTelefone(obj);

                dgTelefone.DataSource = Cadastro.ListarTelefones();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }


        }

       
    }
}
