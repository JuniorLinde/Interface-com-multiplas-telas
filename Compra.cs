using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoComMultiplasJanelas
{
    internal class Compra
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Id do Produto")] public string IdProduto { get; set; }
        [DisplayName("Id do Fornecedor")] public string IdFornecedor { get; set; }
        [DisplayName("Quantidade Comprada")] public int Quantidade { get; set; }
        [DisplayName("Porcentagem de Desconto")] public string Desconto { get; set; }
        [DisplayName("Data da Compra")] public DateTime DataCompra { get; set; }
    }
}
