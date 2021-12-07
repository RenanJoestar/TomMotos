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
    class EmailDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        #region METODO CADASTRAR

        public void cadastrarEmail(EmailModel obj)
        {
          
            if (obj.nome == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    string insert = @"CALL criacaoEmail(@nome, @id)";

                    MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                    executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                    executacmdsql.Parameters.AddWithValue("@id", EmailModel.id);

                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cadastrado não Realizado! " + erro.Message);
                }
                conexao.Close();
            }
        }
        #endregion

        #region METODO CADASTRAR SENHA USUARIO

        public void cadastrarSenha(EmailModel obj)
        {
              try
                {
                    string update_usuario = @"Update tb_usuario set senha=@senha where id_usuario = @id";

                    MySqlCommand executacmdsql = new MySqlCommand(update_usuario, conexao);                  
                    executacmdsql.Parameters.AddWithValue("@senha", obj.senha_usuario);
                    executacmdsql.Parameters.AddWithValue("@id", EmailModel.id_usuario);
                  
                     conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Senha cadastrada e enviada com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cadastrado de Senha não Realizado!");
                    MessageBox.Show("Erro: " + erro.Message);
                }
            conexao.Close();
        }
        
        #endregion

        #region METODO LISTAR
        public DataTable ListarEmails()
        {


            string sql = @"select id_email AS 'ID', nome_email AS 'NOME' from tb_email where fk_usuario_id = @id";

            conexao.Open();
            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
            executacmdsql.Parameters.AddWithValue("@id", EmailModel.id);

            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaEmail = new DataTable();
            da.Fill(tabelaEmail);

            conexao.Close();
            return tabelaEmail;
        }

        #endregion

        #region METODO ALTERAR
        public void alterar(EmailModel obj)
        {
            if (obj.nome == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    string update = @"CALL UpdateEmail(@nome, @id)";

                    MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                    executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                    executacmdsql.Parameters.AddWithValue("@id", EmailModel.id_email);

                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    MessageBox.Show("Alterado com sucesso!");
                    conexao.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show("Alteração não Realizada! " + erro.Message);
                }

            }
            conexao.Close();
        }
        #endregion

        #region METODO EXCLUIR
        public void Excluir(EmailModel obj)
        {
            if (EmailModel.id_email != "")
            {
                var result = MessageBox.Show("Deseja excluir o Telefone " + obj.nome + "?", "EXCLUIR",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {

                    try
                    {

                        string delete = @"Delete from tb_email  where id_email = @id";
                        MySqlCommand executacmdsql = new MySqlCommand(delete, conexao);
                        executacmdsql.Parameters.AddWithValue("@id", EmailModel.id_email);
                        executacmdsql.Parameters.AddWithValue("@nome", obj.nome);

                        conexao.Open();
                        executacmdsql.ExecuteNonQuery();
                        MessageBox.Show("Excluido com Sucesso!");
                        conexao.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Aconteceu um Erro" + erro.Message);
                        MessageBox.Show("Não foi possivel excluir", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            conexao.Close();
        }


        #endregion
       }
    }

