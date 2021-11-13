using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class ClienteModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string data_nasc { get; set; }
        public string cpf { get; set; }
        public string cnpj { get; set; }
        public static string fk_cliente {get; set; }//Vai receber o fk do orçamento
    }
}

