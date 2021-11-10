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
            string sql = @"select*from tb_funcionario";

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

        #region METODO LISTAR CARGO
        public DataTable ListarTodosCargos()
        {
            string sql = @"select * from tb_cargo";

            MySqlCommand executacmdsql = new MySqlCommand(sql, conexao);

            conexao.Open();
            executacmdsql.ExecuteNonQuery();

            MySqlDataAdapter da = new MySqlDataAdapter(executacmdsql);

            DataTable tabelaCargo = new DataTable();
            da.Fill(tabelaCargo);

            conexao.Close();

            return tabelaCargo;
        }
        #endregion

        #region METODO CADASTRAR

        public void cadastrarFuncionario(FuncionarioModel obj)
        {
            int a =1;
            if (obj.nome == "" || obj.cpf == ""|| obj.cargo_fk == "")
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
                    executacmdsql.Parameters.AddWithValue("@cpf", obj.cpf);
                    executacmdsql.Parameters.AddWithValue("@data_nasc", obj.data_nasc);
                    executacmdsql.Parameters.AddWithValue("@data_contratacao", obj.data_contratacao);
                    executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
                    executacmdsql.Parameters.AddWithValue("@cargo_fk", obj.cargo_fk);


                    conexao.Open();
                    executacmdsql.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    a = 2;
                    MessageBox.Show("Erro: " + erro);
                }
                if (a==1)
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

        #region METODO ALTERAR
        public void alterar(FuncionarioModel obj)
        {
            try
            {

                string update = @"Update  tb_funcionario set  nome_funcionario=@nome, sobrenome_funcionario=@sobrenome,cpf_funcionario=@cpf,data_nascimento_funcionario=@data_nasc,
data_contratacao_funcionario=@data_contratacao, sexo_funcionario=@sexo, fk_cargo_id=@cargo_fk where id_funcionario=@id";
                MySqlCommand executacmdsql = new MySqlCommand(update, conexao);
                executacmdsql.Parameters.AddWithValue("@id", obj.id);
                executacmdsql.Parameters.AddWithValue("@nome", obj.nome);
                executacmdsql.Parameters.AddWithValue("@sobrenome", obj.sobrenome);
                executacmdsql.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmdsql.Parameters.AddWithValue("@data_nasc", obj.data_nasc);
                executacmdsql.Parameters.AddWithValue("@data_contratacao", obj.data_contratacao);
                executacmdsql.Parameters.AddWithValue("@sexo", obj.sexo);
                executacmdsql.Parameters.AddWithValue("@cargo_fk", obj.cargo_fk);
                conexao.Open();
                executacmdsql.ExecuteNonQuery();
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um Erro" + erro);
            }


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


        }
        #endregion


    }
}
