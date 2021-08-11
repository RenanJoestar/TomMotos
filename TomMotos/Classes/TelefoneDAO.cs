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
            int a = 1;
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

    }
}
