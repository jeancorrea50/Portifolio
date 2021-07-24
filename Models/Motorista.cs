using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Motorista
    {
        public int ID { get; set; }
        public string NomeCompletoMot { get; set; }
        public int CpfMot { get; set; }

        public string EmailMot { get; set; }
        public DateTime DataNascimentoMot { get; set; }

        // (Propriedade de navegação de referencia) Indico que Motorista está ligado a Veiculo, e que cada Motorista precisa ter um Veiculo vinculado.
        public Veiculo Veiculo { get; set; }
    }
}
