using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalCabTer
{
    public decimal DoctoLegalCabTerId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public byte DlcTipoDato { get; set; }

    public double DlcMtoAfecto { get; set; }

    public double DlcMtoAfectoLocal { get; set; }

    public double DlcMtoAfectoConv { get; set; }

    public double DlcMtoExento { get; set; }

    public double DlcMtoExentoLocal { get; set; }

    public double DlcMtoExentoConv { get; set; }

    public double DlcMtoDescto { get; set; }

    public double DlcMtoDesctoLocal { get; set; }

    public double DlcMtoDesctoConv { get; set; }

    public double DlcMtoRecargo { get; set; }

    public double DlcMtoRecargoLocal { get; set; }

    public double DlcMtoRecargoConv { get; set; }

    public double DlcMtoIva { get; set; }

    public double DlcMtoIvaLocal { get; set; }

    public double DlcMtoIvaConv { get; set; }

    public double DlcMtoImptoEsp { get; set; }

    public double DlcMtoImptoEspLocal { get; set; }

    public double DlcMtoImptoEspConv { get; set; }

    public double DlcMtoRetencion { get; set; }

    public double DlcMtoRetencionLocal { get; set; }

    public double DlcMtoRetencionConv { get; set; }

    public double DlcMtoCreditoIva { get; set; }

    public double DlcMtoCreditoIvaLocal { get; set; }

    public double DlcMtoCreditoIvaConv { get; set; }

    public double DlcMtoIvaRetenido { get; set; }

    public double DlcMtoIvaRetenidoLocal { get; set; }

    public double DlcMtoIvaRetenidoConv { get; set; }

    public double DlcMtoTotal { get; set; }

    public double DlcMtoTotalLocal { get; set; }

    public double DlcMtoTotalConv { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
