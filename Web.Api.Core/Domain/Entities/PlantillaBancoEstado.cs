using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class PlantillaBancoEstado
    {
        public string Rut { get; set; }

        public string RazonSocial { get; set; }

        public string Correo { get; set; }

        public string Banco { get; set; }

        public string FormaPago { get; set; }

        public string NCuenta { get; set; }

        public string SectorFinanciero { get; set; }

        public double MontoPago { get; set; }

        public string SucursalBech { get; set; }
    }
}
