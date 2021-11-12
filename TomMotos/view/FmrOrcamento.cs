using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;

namespace TomMotos.view
{
    public partial class FmrOrcamento : Form
    {
        string[] item = new string[7];
        Fmrcaixa lp;
        VendaDAO VendaDAO = new VendaDAO();
        Fmrcaixa fmrCx = new Fmrcaixa();
        ProdutoUsadoDAO ProdutoUsadoDAO = new ProdutoUsadoDAO();

        public FmrOrcamento(Fmrcaixa lpp)
        {
            InitializeComponent();
            lp = lpp;
        }

        private void FmOrcamento_Load(object sender, EventArgs e)
        {
            dgOrcamento.DataSource = VendaDAO.listarOrcamento();
        }

        private void dgOrcamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fmrCx.Show();
            carregarVenda(int.Parse(dgOrcamento.CurrentRow.Cells[0].Value.ToString())); // ID VENDA
        }

        public void carregarVenda(int idVenda)
        {
            carregarProdutoUsados(idVenda); 
            carregarServicosFeitos(idVenda);
        }
        
        public void carregarServicosFeitos(int idVenda)
        {
            try
            {
            }
            catch (Exception erro) { MessageBox.Show("Test " + erro); }
        }
        public void carregarProdutoUsados(int idVenda)
        {
            try
            {
                int ITEM = 1;
                ArrayList resultado = ProdutoUsadoDAO.listarPorVenda(idVenda);
                MessageBox.Show(resultado.Count.ToString());
                for (int i = -1; i < resultado.Count; ITEM++)
                {
                    if (ITEM == 1) i++;
                    string CODIGO = resultado[i].ToString(); i++;
                    string DESCRICAO = resultado[i].ToString(); i++;
                    string QTD = resultado[i].ToString(); i++;
                    string VLUNIT = resultado[i].ToString(); i++;
                    string DESCONTO = resultado[i].ToString(); i++;

                    item[0] = ITEM.ToString();
                    item[1] = CODIGO; // CODIGO
                    item[2] = DESCRICAO; // DESCRIÇÃO
                    item[3] = QTD; // QTD
                    item[4] = VLUNIT; // VL.UNIT
                    item[5] = DESCONTO; // DESCONTO
                    item[6] = (double.Parse(QTD) * double.Parse(VLUNIT) - double.Parse(QTD) * double.Parse(VLUNIT) * double.Parse(DESCONTO) / 100).ToString();

                    fmrCx.dgProdutos.Rows.Add(item);
                }
            }
            catch (Exception erro) { MessageBox.Show("Test " + erro); }
        }

        private void dgOrcamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
