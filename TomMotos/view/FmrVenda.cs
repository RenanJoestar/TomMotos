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
    public partial class FmrVenda : Form
    {
        VendaDAO VendaDAO = new VendaDAO();
        FiltroDAO Filtro = new FiltroDAO();
        public FmrVenda()
        {
            InitializeComponent();
        }

        private void FmrVendacs_Load(object sender, EventArgs e)
        {
            cxbData.Checked = true;
            dtp1.Value = dtp1.Value.AddDays(-14);
            pesquisarVendaComFiltro(); //Puxa todos os orçamentos de 2 semanas para cá
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarVendaComFiltro();
        }
        private void pesquisarVendaComFiltro()
        {
            try
            {
                string campo = cbxBuscar.Text.ToString();
                string finalSQL = "tb_venda.e_orcamento = false";
                if (campo == "ID DO ORÇAMENTO") campo = "tb_venda.id_venda";
                if (campo == "NOME DO CLIENTE") campo = "tb_cliente.nome_cliente";
                if (campo == "CPF DO CLIENTE") campo = "tb_cliente.cpf_cliente";
                if (campo == "CNPJ DO CLIENTE") campo = "tb_cliente.cnpj_cliente";
                if (campo != "") finalSQL += " AND " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
                if (cxbData.Checked)
                {
                    finalSQL = finalSQL + " AND tb_venda.data_venda BETWEEN ' " + dtp1.Value.ToString("yyyy/MM/dd") + " 00:00:00' AND ' " + dtp2.Value.ToString("yyyy/MM/dd") + " " + "23:59:59'";
                }
                FiltroModel.campoWhere = finalSQL;

                dgVenda.DataSource = Filtro.buscaVenda();
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }
        private void btn_mostrar_tudo_Click(object sender, EventArgs e)
        {
            dgVenda.DataSource = VendaDAO.listarTodos(false); //Puxa todas as vendas
            txtBuscar.Text = "";
            cbxBuscar.Text = "";
            cxbData.Checked = false;
        }

        private void dgVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgVenda.CurrentRow.Cells[0].Value.ToString();
        }

        private void Exibir() {

            FmrShowVendas Showfunc = new FmrShowVendas(this);
            if (textBox1.Text.Replace(" ", "") != "")
            {
                if (rb_Func.Checked == true)
                {
                    FiltroModel.campoWhere = @"select tb_funcionario.id_funcionario AS 'ID FUNCIONARIO', tb_funcionario.nome_funcionario AS 'NOME',
                    tb_funcionario.sobrenome_funcionario AS 'SOBRENOME', tb_cargo.nome_cargo AS 'CARGO'
                    from tb_grupo_funcionarios
                    inner join tb_funcionario
                    on tb_grupo_funcionarios.fk_funcionario_id = tb_funcionario.id_funcionario
                    inner join tb_cargo
                    on tb_cargo.id_cargo = tb_funcionario.fk_cargo_id 
                    inner join tb_venda 
                    on tb_grupo_funcionarios.fk_venda_id = tb_venda.id_venda
                    where id_venda = " + textBox1.Text.ToString();
                    Showfunc.Show();
                }
                if (rb_Pv.Checked == true)
                {
                    FiltroModel.campoWhere = @"select tb_produto.id_produto AS 'ID', tb_produto.descricao_produto AS 'DESCRIÇÃO',tb_produto.marca_produto AS 'MARCA',tb_produto.valor_produto AS 'VALOR(R$)',
                    tb_produto_usado.quantidade_produto_usado AS 'QTD VENDIDA', tb_produto_usado.desconto_produto_usado AS 'DESCONTO(%)', tb_produto_usado.validade_da_garantia_produto AS 'VALIDADE GARANTIA' from tb_produto_usado
                    inner join tb_produto
                    on tb_produto_usado.fk_produto_id = tb_produto.id_produto            
                    inner join tb_venda 
                    on tb_produto_usado.fk_venda_id = tb_venda.id_venda
                    where id_venda = " + textBox1.Text.ToString();
                    Showfunc.Show();
                }
                if (rb_Sp.Checked == true)
                {
                    FiltroModel.campoWhere = @"select tb_servico_prestado.descricao_servico_prestado AS 'DESCRIÇÃO', tb_servico_prestado.valor_servico_prestado AS 'VALOR' from tb_servico_prestado
                    where fk_venda_id = " + textBox1.Text.ToString();
                    Showfunc.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exibir();
        }
    }
}

