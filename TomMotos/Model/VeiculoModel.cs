using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class VeiculoModel
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string cor_veiculo { get; set; }
        public string ano_veiculo { get; set; }
        public string km_veiculo { get; set; }
        public string placa_veiculo { get; set; }
        public string obs_veiculo { get; set; }
        public string cliente_fk { get; set; }
        public static string fk_veiculo { get; set; }
    }
}
