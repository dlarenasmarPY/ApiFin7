using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Api.Core.Domain.Entities
{
    public class BalanceCuentasPagarCentroCostoProvision
    {
        public Decimal EmpId { get; set; }

        public string Empresa { get; set; }

        public string Rut { get; set; }

        public string Cliente { get; set; }

        public int Cuenta { get; set; }

        public string NomCuenta { get; set; }

        public int CCosto { get; set; }

        public string NomCCosto { get; set; }

        public Decimal CodMoneda { get; set; }

        public DateTime Vencimiento { get; set; }

        public DateTime Contable { get; set; }

        public int CodDocumento { get; set; }

        public string GloDocumento { get; set; }

        public string Documento { get; set; }

        public int nroCuota { get; set; }

        public string GloMoneda { get; set; }

        public double DebeImpu { get; set; }

        public double HaberImpu { get; set; }

        public double SaldoImpu { get; set; }

        public double DebeLocal { get; set; }

        public double HaberLocal { get; set; }

        public double SaldoPesos { get; set; }
    }
}
