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
    public partial class Fmrcargo : Form
    {


        public Fmrcargo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
       {
            try
            {

                CargoDAO Cadastro = new CargoDAO();
                CargoModel obj = new CargoModel();


                obj.nome = txt_nome.Text;
                obj.salario = txt_salario.Text;

                Cadastro.cadastrarCargo(obj);


                dgCargo.DataSource = Cadastro.ListarTodosCargos();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro: " + erro);
            }



        }


        private void Fmrcargo_Load(object sender, EventArgs e)
        {
            CargoDAO Cadastro = new CargoDAO();
            dgCargo.DataSource = Cadastro.ListarTodosCargos();
        }
    }
}

