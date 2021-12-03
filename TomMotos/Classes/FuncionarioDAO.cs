using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomMotos.Conexao;
using TomMotos.Model;

namespace TomMotos.Classes
{
    class FuncionarioDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();

        public FuncionarioDAO()
        {
        }

        #region METODO LISTAR
        public DataTable ListarTodosFuncionario()
        {
            string sql = @"select tb_funcionario.id_funcionario, tb_funcionario.nome_funcionario,
            tb_funcionario.sobrenome_funcionario, tb_funcionario.cpf_funcionario, tb_funcionario.data_nascimento_funcionario,
            tb_funcionario.data_contratacao_funcionario, tb_funcionario.sexo_funcionario, tb_cargo.nome_cargo
            from tb_funcionario
            inner join tb_cargo
            on tb_cargo.id_cargo = tb_funcionario.fk_cargo_id";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaFuncionario = new DataTable();
            da.Fill(tabelaFuncionario);

            conexao.Close();

            return tabelaFuncionario;
        }
        #endregion

        #region METODO CADASTRAR

        public void cadastrarFuncionario(FuncionarioModel obj)
        {
            if (obj.nome == "" || FuncionarioModel.cpf == ""|| obj.cargo_fk == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
            }
            else {
                try
                {
                    string insert = @"CALL criacaoFuncionario(@nome, @sobrenome,@cpf, @data_nasc, @data_contratacao, @sexo,@cargo_fk)";

                    MySqlCommand executacmdsql = new MySqlCommand(insert, conexao);
                    executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                    executacmdsql.Parameters.AddWithValue("@sobrenome", obj.sobrenome);
                    executacmdsql.Parameters.AddWithValue("@cpf", FuncionarioModel.cpf);
                    executacmdsql.Parameters.AddWithValue("@data_nasc", obj.data_nasc);
                    executacmdsql.Parameters.AddWithValue("@data_contratacao", obj.data_contratacao);
                    executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
                    executacmdsql.Parameters.AddWithValue("@cargo_fk", obj.cargo_fk);
                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Cadastrado Realizado com sucesso! ");
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Cadastrado não Realizado! " + erro.Message);
                }
                
            }
            conexao.Close();
        }

        #endregion

        #region METODO ALTERAR
        public void alterar(FuncionarioModel obj)
        {
            try
            {

                string update = @" CALL UpdateFuncionario (@nome, @sobrenome, @cpf, @data_nasc,@data_contratacao,@sexo,@cargo_fk,@id)";
                MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                executacmdsql.Parameters.AddWithValue("@id", obj.id);
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@sobrenome", obj.sobrenome);
                executacmdsql.Parameters.AddWithValue("@cpf", FuncionarioModel.cpf);
                executacmdsql.Parameters.AddWithValue("@data_nasc", obj.data_nasc);
                executacmdsql.Parameters.AddWithValue("@data_contratacao", obj.data_contratacao);
                executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmdsql.Parameters.AddWithValue("@cargo_fk", obj.cargo_fk);
                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Alterado com Sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro" + erro.Message);
            }

            conexao.Close();
        }
        #endregion

        #region METODO EXCLUIR
        public void Excluir(FuncionarioModel obj)
        {
            try
            {

                string delete = @"Delete from tb_funcionario where id_funcionario=@id";
               
                MySqlCommand executacmdsql = new MySqlCommand(delete, conexao);
               
                executacmdsql.Parameters.AddWithValue("@id", obj.id);
               

                conexao.Open();
                executacmdsql.ExecuteNonQuery();
               
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro" + erro);
            }
            conexao.Close();

        }
        #endregion
    }
}
