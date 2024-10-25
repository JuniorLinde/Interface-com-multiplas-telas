using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoComMultiplasJanelas
{
    internal class Cliente
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome do Cliente")] public string CNPJ { get; set; }
        [DisplayName("Número de Telefone")] public string NomeEmpresa { get; set; }
        [DisplayName("Endereço de E-mail")] public int NomeContato { get; set; }
        [DisplayName("Endereço Físico")] public string Telefone { get; set; }
    }
}
