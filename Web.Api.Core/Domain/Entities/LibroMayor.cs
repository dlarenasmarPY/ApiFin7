using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class LibroMayor
    {
        public Decimal empId { get; set; }

        public string razonEmpresa { get; set; }

        public short periodo { get; set; }

        public string periodoGlosa { get; set; }

        public short codComprobante { get; set; }

        public string gloComprobante { get; set; }

        public int nroComprobante { get; set; }

        public DateTime fechaComprobante { get; set; }

        public string glosaCentralizacion { get; set; }

        public int linea { get; set; }

        public int cuenta { get; set; }

        public string gloCuenta { get; set; }

        public Decimal codMoneda { get; set; }

        public string gloMoneda { get; set; }

        public double debeImpu { get; set; }

        public double haberImpu { get; set; }

        public double debeLocal { get; set; }

        public double haberLocal { get; set; }

        public double debeFunci { get; set; }

        public double haberFunci { get; set; }

        public int codCcosto { get; set; }

        public string gloCcosto { get; set; }

        public string UserDig { get; set; }
    }
}
