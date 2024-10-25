using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoComMultiplasJanelas
{
    internal class Venda
    {
        public int Id { get; set; }
        [DisplayName("Id do Produto")] public string IdProduto { get; set; }
        [DisplayName("Id do Cliente")] public string IdCliente { get; set; }
        [DisplayName("Quantidade Vendida")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de Desconto")] public string Desconto { get; set; }
        [DisplayName("Data da Compra")] public DateTime DataVenda { get; set; }
    }
}
