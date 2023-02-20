using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTPreEmbarqueDet
{
    public decimal PreEmbarqueDetId { get; set; }

    public decimal PPreEmbarqueId { get; set; }

    public decimal POcCabId { get; set; }

    public string DocEmbNum { get; set; } = null!;

    public decimal PConceptoImpId { get; set; }

    public byte IndContabilizaConcepto { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PCctaId { get; set; }

    public decimal PCcreId { get; set; }

    public decimal PCcdiId { get; set; }

    public decimal PCtprId { get; set; }

    public string PryNumeroCtaCta { get; set; } = null!;

    public decimal PPartidaId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public decimal PMonedaId { get; set; }

    public double DocEmbValCom { get; set; }

    public DateTime DocEmbFecPar { get; set; }

    public decimal DetEmbCantFac { get; set; }

    public decimal DocEmbParidad { get; set; }

    public double DocEmbCosDir { get; set; }

    public int MonFuncTasaCambio { get; set; }

    public double MonFuncMonto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
