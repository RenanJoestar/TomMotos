using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.Classes
{
    class EnderecoDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();



        #region METODO CADASTRAR

        public void cadastrarEndereco(EnderecoModel obj)
        {
            int a = 1;
            if (obj.endereco == "" || obj.numero =="")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    string insert = @"CALL criacaoEndereco(@cep, @rua, @cidade, @bairro, @numero, @id)";

                    MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                    executacmdsql.Parameters.AddWithValue("@id", EnderecoModel.id);
                    executacmdsql.Parameters.AddWithValue("@cep", obj.cep);
                    executacmdsql.Parameters.AddWithValue("@rua", obj.endereco);
                    executacmdsql.Parameters.AddWithValue("@cidade", obj.cidade);
                    executacmdsql.Parameters.AddWithValue("@bairro", obj.bairro);
                    executacmdsql.Parameters.AddWithValue("@numero", obj.numero);
                    
                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
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
        }
        #endregion


        #region METODO LISTAR
        public DataTable ListarEndereco()
        {


            string sql = @"select * from tb_endereco where fk_usuario_id = @id";

            conexao.Open();
            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@id", EnderecoModel.id);


            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaEndereco = new DataTable();
            da.Fill(tabelaEndereco);

            conexao.Close();
            return tabelaEndereco;

        }

        #endregion
    }
}
