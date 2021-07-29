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
    public partial class Fmrproduto : Form

    {
        Bitmap image;
        string base64Text;
        public Fmrproduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG" +
            "|All files(*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ptb_perfil.ImageLocation = openFileDialog1.FileName;
                ptb_perfil.Load();
                lblCaminho.Text = "Caminho do arquivo: " + openFileDialog1.FileName;
                image = new Bitmap(openFileDialog1.FileName);
                ptb_perfil.Image = (Image)image;

                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                base64Text = Convert.ToBase64String(imageArray); //convertendo para base64
                
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int a = 1;

            try
            {
                ProdutoModel obj = new ProdutoModel();

                
                obj.descricao = txt_descricao_produto.Text;
                obj.quantidade = int.Parse(np_quantidade.Text);
                obj.quantidade_virtual = int.Parse(np_quantidade.Text);
                obj.valor = int.Parse(txt_valor_produto.Text);
                obj.marca= txt_marca_produto.Text;
                obj.imagem = base64Text;
                

                ProdutoDAO Cadastro = new ProdutoDAO();

                Cadastro.cadastrarProduto(obj);


                dg_produto.DataSource = Cadastro.ListarTodosProdutos();
            }
            catch (Exception erro)
            {
                a = 2;
                MessageBox.Show("Erro: " + erro);
            }



            if (a == 1)
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cadastrado não Realizado!");
            }
        }

        private void Fmrproduto_Load(object sender, EventArgs e)
        {
            ProdutoDAO Cadastro = new ProdutoDAO();
            dg_produto.DataSource = Cadastro.ListarTodosProdutos();

        }
    }
}
