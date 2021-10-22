using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomMotos.Model
{
    class ProdutoUsadoModel
    {
        public double quantidade_produto_usado { get; set; }
        public int fk_produto_id { get; set; }
        public int fk_venda_id { get; set; }
        public DateTime validade_da_garantia_produto { get; set; }
       
    }
}
