using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class NotaFiscal
    {
        public int ID { get; set; }
        public int NumeroNf { get; set; }
        public int SerieNf { get; set; }
        public string RemetenteNf { get; set; }
        public string DestinatarioNf { get; set; }
        public DateTime DataEmissaoNf { get; set; }
        public double ValorNf { get; set; }
        public string ProdutoNf { get; set; }
        public double PesoNf { get; set; }
        public double QuantidadeNf { get; set; }

        // (Propriedade de navegação de referencia) Indico que Produtos está ligado a Clientes, e que cada produto precisa ter um cliente vinculado.
        public Veiculo Veiculo { get; set; }
    }
}
