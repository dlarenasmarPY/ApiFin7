using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class Cuotas
    {
        public int NumeroCuota { get; set; }

        public double MontoCuota { get; set; }

        public string FechaVencimiento { get; set; }
    }
}
