using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Agenda
    {
        // gerar um identificador unico (Guild)
        public Guid Id { get; set; }
        public DateTime DataHoraAge { get; set; }

        public ICollection<NotaFiscal> NotaFiscal { get; set; }



        // gerar um identificador unico (Guild)

        public Agenda()
        {
            Id = Guid.NewGuid();
        }

    }
      

}
