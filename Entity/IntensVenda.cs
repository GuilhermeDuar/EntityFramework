using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class ItensVenda
    {
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }

        public int VendaID { get; set; }
        public Venda Venda { get; set; }

        public double  Quantidade { get; set; }
        public double Valor { get; set; }




    }
}
