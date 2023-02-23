using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class SmartSheetComisiones
    {
        public string PtprId { get; set; }
        public string EntNomFantasia { get; set; }
        public string CreNombre { get; set; }
        public string InmuebleCodigo { get; set; }
        public string CreCodigo { get; set; }
        public string Zona { get; set; }
        public string EntRut { get; set; }
        public string EntRazonSocial { get; set; }
        public string PrecioVentaInm { get; set; }
        public string CarOfeNumInterno { get; set; }
        public string CarOfeFecha { get; set; }
        public string FechaPromesa { get; set; }
        public string EstadoActual { get; set; }
        public string TprGlosa { get; set; }
        public string Migrado { get; set; }
    }
}
