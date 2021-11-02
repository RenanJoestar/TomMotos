using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TomMotos.Conexao;

namespace TomMotos.Classes
{
    class FinalizarVendaDAO
    {
        MySqlConnection conexao = ConnectionFactory.getConnection();
        
    }
}
