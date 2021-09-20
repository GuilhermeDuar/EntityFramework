using Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public double  Preco { get; set; }
        public double estoque { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

    }

}
