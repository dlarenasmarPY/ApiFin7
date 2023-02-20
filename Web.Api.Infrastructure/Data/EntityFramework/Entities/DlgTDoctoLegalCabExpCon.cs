using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalCabExpCon
{
    public decimal PDoctoLegalCabId { get; set; }

    public byte EmcIndPago { get; set; }

    public byte EmcIndTipoPago { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PEntId { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public double DlcMtoConcepto { get; set; }

    public double DlcMtoVario { get; set; }

    public double DlcMtoVarioLocal { get; set; }

    public double DlcMtoVarioConv { get; set; }

    public decimal PCtaId { get; set; }
}
