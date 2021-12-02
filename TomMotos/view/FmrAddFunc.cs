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
    public partial class FmrAddFunc : Form
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();
        CaixaModel obj = new CaixaModel();
        VendaDAO Cadastro = new VendaDAO();
        Fmrcaixa fmrCx = new Fmrcaixa();

        public FmrAddFunc()
        {
            InitializeComponent();
        }


        private void FmrAddFunc_Load_1(object sender, EventArgs e)
        {
            //dg_func.DataSource = ListarTodosFuncionario();

        }

       


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dg_FuncGet.Rows.Count >= 0)
            {
                for (int i = 0; i < dg_FuncGet.Rows.Count; i++)
                {
                    try
                    {
                        CaixaModel.fk_funcionario_id = dg_FuncGet.Rows[i].Cells[0].Value.ToString();

                        CaixaModel.id_venda = Cadastro.listarUltimaVenda();

                        Cadastro.cadastrarGrupoFunc(obj);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        return;
                    }
                    MessageBox.Show("Grupo criado!");
                    CaixaModel.id_venda = "";
                    this.Close();
                }

            }
        }

        private void dg_func_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dg_func.Columns["Estado"].Index)
            {
                dg_func.EndEdit();
                if (dg_func.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    string[] funcionario = new string[3];
                    funcionario[0] = dg_func.CurrentRow.Cells[1].Value.ToString();
                    funcionario[1] = dg_func.CurrentRow.Cells[2].Value.ToString();
                    funcionario[2] = dg_func.CurrentRow.Cells[3].Value.ToString();
                    fmrCx.dg_funcGet.Rows.Add(funcionario);
                }
                else if (dg_func.Rows[e.RowIndex].Cells[0].Value.ToString() == "False")
                {
                    string[] funcionario = new string[3];
                    funcionario[0] = dg_func.CurrentRow.Cells[1].Value.ToString();
                    string rowProduto = funcionario[0];
                    //int VALOR = dg_FuncGet.Rows.Cells["ID"][rowProduto.ToString()];//.Value.ToString() == rowProduto.ToString());
                    for (int v = 0; v < dg_FuncGet.Rows.Count; v++)
                    {
                        if (string.Equals(dg_FuncGet[0, v].Value as string, rowProduto))
                        {
                            fmrCx.dg_funcGet.Rows.RemoveAt(v);
                            v--; // this just got messy. But you see my point.
                        }
                    }
                }

            }
        }

    }
}
