using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class EnderecoModel
    {
        public static string id { set; get; }
        public static string id_endereco { set; get; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string cidade { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
       

    }
}
