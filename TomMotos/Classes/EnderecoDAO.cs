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
                    MessageBox.Show("Cadastrado com sucesso!");
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cadastrado não Realizado! "+ erro.Message);
                }
                            
            }
            conexao.Close();
        }
        #endregion

        #region METODO LISTAR
        public DataTable ListarEndereco()
        {
            string sql = @"select id_endereco, rua_endereco AS 'RUA', numero_endereco AS 'NÚMERO',  bairro_endereco AS 'BAIRRO', cidade_endereco AS 'CIDADE', cep_endereco AS 'CEP'  from tb_endereco where fk_usuario_id = @id";

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

        #region METODO ALTERAR
        public void alterar(EnderecoModel obj)
        {
            
            if (obj.endereco == ""|| obj.numero == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    string update = @"CALL UpdateEndereco (@cep,@rua,@cidade,@bairro,@numero,@fk,@id)";

                    MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                    executacmdsql.Parameters.AddWithValue("@id", EnderecoModel.id_endereco);
                    executacmdsql.Parameters.AddWithValue("@fk", EnderecoModel.id);
                    executacmdsql.Parameters.AddWithValue("@cep", obj.cep);
                    executacmdsql.Parameters.AddWithValue("@rua", obj.endereco);
                    executacmdsql.Parameters.AddWithValue("@cidade", obj.cidade);
                    executacmdsql.Parameters.AddWithValue("@bairro", obj.bairro);
                    executacmdsql.Parameters.AddWithValue("@numero", obj.numero);

                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Alterado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Alteração não Realizado! " + erro.Message);
                }
                
            }
            conexao.Close();
        }
        #endregion

        #region METODO EXCLUIR
        public void Excluir(EnderecoModel obj)
        {
            if (EnderecoModel.id_endereco != "")
            {
                var result = MessageBox.Show("Deseja excluir o Endereço " + obj.endereco + "?", "EXCLUIR",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        string delete = @"Delete from tb_endereco  where id_endereco = @id";
                        MySqlCommand executacmdsql = new MySqlCommand(delete, conexao);
                        executacmdsql.Parameters.AddWithValue("@id", EnderecoModel.id_endereco);
                        executacmdsql.Parameters.AddWithValue("@cep", obj.cep);
                        executacmdsql.Parameters.AddWithValue("@rua", obj.endereco);
                        executacmdsql.Parameters.AddWithValue("@cidade", obj.cidade);
                        executacmdsql.Parameters.AddWithValue("@bairro", obj.bairro);
                        executacmdsql.Parameters.AddWithValue("@numero", obj.numero);

                        conexao.Open();
                        executacmdsql.ExecuteNonQuery();
                        MessageBox.Show("Excluido com Sucesso!");
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            conexao.Close();
        }
        #endregion

      
    }
}
