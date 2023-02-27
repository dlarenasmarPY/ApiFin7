using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class CuotaPromesa
    {
        public string inmueble { get; set; }

        public string IdCliente { get; set; }

        public string Empresa { get; set; }

        public string Proyecto { get; set; }

        public decimal PtprId { get; set; }

        public string PryNumero { get; set; }

        public string Nombre { get; set; }

        public int CartaOferta { get; set; }

        public string Descripcion { get; set; }

        public string Vencimiento { get; set; }

        public short Cuota { get; set; }

        public double Monto { get; set; }

        public string Rut { get; set; }

        public string Zona { get; set; }

        public string IdentificadorCuota { get; set; }

        public string mesAnio { get; set; }
    }
}
