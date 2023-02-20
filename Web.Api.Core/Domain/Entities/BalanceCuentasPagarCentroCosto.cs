using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class BalanceCuentasPagarCentroCosto
    {
        public Decimal EmpId { get; set; }

        public string Empresa { get; set; }

        public string Rut { get; set; }

        public string Cliente { get; set; }

        public int Cuenta { get; set; }

        public string NomCuenta { get; set; }

        public int? CCosto { get; set; }

        public string NomCCosto { get; set; }

        public Decimal Cod_Moneda { get; set; }

        public DateTime Contable { get; set; }

        public int Cod_documento { get; set; }

        public string Glo_Documento { get; set; }

        public string Documento { get; set; }

        public int nro_cuota { get; set; }

        public Decimal CodMoneda { get; set; }

        public string GloMoneda { get; set; }

        public DateTime Vencimiento { get; set; }

        public double debe_impu { get; set; }

        public double haber_impu { get; set; }

        public double saldo_input { get; set; }

        public double debe_local { get; set; }

        public double haber_local { get; set; }

        public double saldo_pesos { get; set; }
    }
}
