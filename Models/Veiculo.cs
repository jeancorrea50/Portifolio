using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Veiculo
    {
        public int ID { get; set; }
        public string PlacaVeic { get; set; }
        public string ModeloVeic { get; set; }
        public string MarcaVeic { get; set; }
        public double CapacidadeLiquidaVeic { get; set; }


        // (Propriedade de navegação de coleção) Estou indicando que o Veiculo pode possuir varias notas fiscais
        public ICollection<NotaFiscal> NotaFiscal { get; set; }
        public ICollection<Motorista> Motorista { get; set; }
    }
}
