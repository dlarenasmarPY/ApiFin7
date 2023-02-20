using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTCoberturaDet
{
    public decimal CoberturaDetId { get; set; }

    public decimal PCoberturaId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public string DocEmbNum { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public DateTime DocEmbFecPar { get; set; }

    public double DocEmbValCom { get; set; }

    public decimal DocEmbParidad { get; set; }

    public double DocEmbCosDir { get; set; }

    public decimal PCondPagoId { get; set; }

    public DateTime DocFechaVenc { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public double TasaCambioAcuerdo { get; set; }

    public byte CargoCtaCte { get; set; }

    public double CobMontoPagado { get; set; }

    public DateTime FechaPago { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
