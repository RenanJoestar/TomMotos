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
    class TelefoneDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();



        #region METODO CADASTRAR

        public void cadastrarTelefone(TelefoneModel obj)
        {
            
            if (obj.nome == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    string insert = @"CALL criacaoTelefone(@nome, @id)";

                    MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                    executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                    executacmdsql.Parameters.AddWithValue("@id", TelefoneModel.id);

                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cadastrado não Realizado! " + erro.Message);
                }                
            }
            conexao.Close();
        }
        #endregion


        #region METODO LISTAR
        public DataTable ListarTelefones()
        {
            
                //tem que mudar o select para a storeProcedur, porém tem que criar o metodo cadastra telefone, email e endereco

                string sql = @"select * from tb_telefone where fk_usuario_id = @id";

                conexao.Open();
                MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);
                executacmdsql.Parameters.AddWithValue("@id", TelefoneModel.id);


                executacmdsql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

                DataTable tabelaTelefones = new DataTable();
                da.Fill(tabelaTelefones);

                conexao.Close();
               return tabelaTelefones;

        }

        #endregion


        #region METODO ALTERAR
        public void alterar(TelefoneModel obj)
        {
           
            if (obj.nome == "")
            {
                MessageBox.Show("Preencha todos valores Obrigatorio! = *");
            }
            else
            {
                try
                {
                    string update = @"Update tb_telefone set numero_telefone=@nome where id_telefone = @id";

                    MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                    executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                    executacmdsql.Parameters.AddWithValue("@id", TelefoneModel.id_telefone);

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
        public void Excluir(TelefoneModel obj)
        {
            if (EnderecoModel.id_endereco != "")
            {
                var result = MessageBox.Show("Deseja excluir o Endereço " + obj.nome + "?", "EXCLUIR",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        string delete = @"Delete from tb_telefone  where id_telefone = @id";
                        MySqlCommand executacmdsql = new MySqlCommand(delete, conexao);
                        executacmdsql.Parameters.AddWithValue("@id", TelefoneModel.id_telefone);
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
