using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Classes;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.view
{
    public partial class Fmrproduto : Form

    {
        MySqlConnection conexao = ConnectionFactory.getConnection();
        
        byte[] base64Text;
        Bitmap image;
      
        public Fmrproduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG" +
                "|All files(*.*)|*.*";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.Multiselect = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ptb_perfil.ImageLocation = openFileDialog1.FileName;
                    ptb_perfil.Load();
                    lblCaminho.Text = "Caminho do arquivo: " + openFileDialog1.FileName;
                    image = new Bitmap(openFileDialog1.FileName);
                    ptb_perfil.Image = (Image)image;
                    MemoryStream imageArray = new MemoryStream();
                    ptb_perfil.Image.Save(imageArray, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = imageArray.ToArray();
                    base64Text = pic;
                    //base64Text = Convert.ToBase64String(imageArray); //convertendo para base64

                }
            }
            catch (Exception erro) {
                MessageBox.Show("Ouve um erro "+erro);
            }
        }
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          
            if (txt_descricao_produto.Text == "" || txt_valor_produto.Text ==""|| np_quantidade.Text ==null)
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    ProdutoModel obj = new ProdutoModel();


                    obj.descricao = txt_descricao_produto.Text.ToUpper();
                    if(np_quantidade.ToString() == "") obj.quantidade = 0;
                    obj.quantidade = int.Parse(np_quantidade.Text);
                    obj.quantidade_virtual = int.Parse(np_quantidade.Text);
                    obj.valor = double.Parse(txt_valor_produto.Text);
                    if (txt_marca_produto.Text == "") obj.marca = null;
                    else obj.marca = txt_marca_produto.Text.ToUpper();
                    obj.imagem = base64Text;


                    ProdutoDAO Cadastro = new ProdutoDAO();

                    Cadastro.cadastrarProduto(obj);


                    dg_produto.DataSource = Cadastro.ListarTodosProdutos();
                }
                catch (Exception erro)
                {
                   
                    MessageBox.Show("Erro: " + erro);
                }
        
          }
        }

        private void Fmrproduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO Cadastro = new ProdutoDAO();
            dg_produto.DataSource = Cadastro.ListarTodosProdutos();
            lblCaminho.Text = "";

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
             try
            {
                ProdutoModel obj = new ProdutoModel();
                obj.id = int.Parse(txt_id.Text);
                obj.descricao = txt_descricao_produto.Text.ToUpper();
                obj.quantidade = int.Parse(np_quantidade.Text);
                obj.quantidade_virtual = int.Parse(np_quantidade.Text);
                obj.valor = double.Parse(txt_valor_produto.Text.ToUpper());
                if (txt_marca_produto.Text == "") obj.marca = null;
                else obj.marca = txt_marca_produto.Text.ToUpper();
                obj.imagem = base64Text;

                ProdutoDAO dao = new ProdutoDAO();
                dao.alterar(obj);
                dg_produto.DataSource = dao.ListarTodosProdutos();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu algum erro" + erro);
            }
            }
            else MessageBox.Show("Escolha um id que deseja Alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dg_produto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dg_produto.CurrentRow.Cells[0].Value.ToString();
            txt_descricao_produto.Text = dg_produto.CurrentRow.Cells[1].Value.ToString();
            np_quantidade.Text = dg_produto.CurrentRow.Cells[2].Value.ToString();            
            txt_valor_produto.Text = dg_produto.CurrentRow.Cells[3].Value.ToString();
            txt_marca_produto.Text = dg_produto.CurrentRow.Cells[4].Value.ToString();
            
            Base64ToImage();

        }

        public Image Base64ToImage()
        {
        if(txt_id.Text != "" ) { 
            try
            {
                string select = @"select imagem_produto from tb_produto where id_produto =" + txt_id.Text;
                MySqlCommand executacmdsql = new MySqlCommand(select, conexao);
                conexao.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (Convert.IsDBNull(ds.Tables[0].Rows[0]["imagem_produto"]))
                        {
                            ptb_perfil.Image = null;
                        }
                        else {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["imagem_produto"]);
                        ptb_perfil.Image = new Bitmap(ms);
                        }

                    }
                    conexao.Close();
            }
            catch (Exception erro)
            {
                    MessageBox.Show("Aconteceu um Erro" + erro);
            }
          }

            else
            {
              
            }
            return image;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ptb_perfil.Image = null;
            lblCaminho.Text = "";
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                var result = MessageBox.Show("Deseja excluir o Fornecedor" + txt_descricao_produto.Text + "?", "EXCLUIR",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ProdutoModel obj = new ProdutoModel();
                        obj.id = int.Parse(txt_id.Text);


                        ProdutoDAO dao = new ProdutoDAO();
                        dao.Excluir(obj);
                        dg_produto.DataSource = dao.ListarTodosProdutos();
                        MessageBox.Show("Excluido com Sucesso!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
         }

        private void Fmrproduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fmrsumario fmrsumario = new Fmrsumario();
            fmrsumario.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
          
            string campo = cbxBuscar.Text.ToString() + "_produto";
            FiltroModel.filtro = @"select * from tb_produto where " + campo.ToLower() + " like " + "'%" + txtBuscar.Text.ToString() + "%'";
            // MessageBox.Show("Test " + FiltroModel.filtro);
            FiltroDAO dao = new FiltroDAO();
            dg_produto.DataSource = dao.buscaCargo();
            }
            catch (Exception erro) { MessageBox.Show("Ouve um Erro " + erro); }
        }
    }
}
