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
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class fmrcliente : Form
    {
        public fmrcliente()
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

                obj.nome = txt_nome.Text;
                obj.sobrenome = txt_sobrenome.Text;
                obj.data_nasc = txt_nascimento.Text;
                obj.cpf = txt_cpf.Text;
                obj.cnpj = txt_cnpj.Text;

                ClienteDAO Cadastro = new ClienteDAO();
                
                Cadastro.cadastrar(obj);
                
                MessageBox.Show("Cadastrado com sucesso!");
                dg_cliente.DataSource = Cadastro.ListarTodosClientes();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }

     
    }
}
