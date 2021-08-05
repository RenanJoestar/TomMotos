using System;
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

                if (txt_nascimento.Text == "") obj.data_nasc = null; // Verifica se a data de nascimento é null
                else obj.data_nasc = txt_nascimento.Text;

                obj.cpf = txt_cpf.Text;

                if (txt_cnpj.Text == "") obj.cnpj = null;  // É interessante perceber que isso não deve ser usado para alguns ints, por exemplo de quantidade tendo em vista
                else obj.cnpj = txt_cnpj.Text;             // que quantidade é um valor que não pode ser armazenado como nulo, se o produto não se encontra 
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

     
    }
}
