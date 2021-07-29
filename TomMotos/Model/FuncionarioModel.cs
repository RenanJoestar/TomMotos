using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class FuncionarioModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public string data_nasc { get; set; }
        public string data_contratacao { get; set; }
        public string sexo { get; set; }
        public string cargo_fk { get; set; }
    }
}
