
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portifolio.Models
{
    public class Agenda
    {
        public Guid Id { get; set; }

        public DateTime DataHoraAgenda { get; set; }

        

        public Agenda()
        {
            Id = Guid.NewGuid();
        }
    }
}
