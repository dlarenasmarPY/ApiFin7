using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTmpPagosCartaOfertum
{
    public string Usuario { get; set; } = null!;

    public decimal PCartaOfertaId { get; set; }

    public short ItemFinId { get; set; }

    public short MovDocCuota { get; set; }

    public DateTime FechaVenc { get; set; }

    public double MontoItemDet { get; set; }

    public decimal PFormaPagoDetId { get; set; }

    public DateTime FechaPago { get; set; }

    public double TipoCambio { get; set; }

    public double MontoItemLocal { get; set; }

    public int InstCod { get; set; }

    public int PlaCod { get; set; }

    public string CtaCteValeVista { get; set; } = null!;

    public string XDocCceNumero { get; set; } = null!;

    public decimal Voucher { get; set; }

    public decimal Comprobante { get; set; }

    public int NroGestionInm { get; set; }

    public decimal PEmpId { get; set; }

    public double Saldo { get; set; }

    public DateTime FechaContable { get; set; }
}
