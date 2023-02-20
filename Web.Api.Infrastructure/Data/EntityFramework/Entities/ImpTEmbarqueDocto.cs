using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueDocto
{
    public decimal EmbarqueDocId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public decimal PClaseImpId { get; set; }

    public byte ClaseImpInd { get; set; }

    public string DocEmbNum { get; set; } = null!;

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public DateTime DocEmbFec { get; set; }

    public decimal PMonedaId { get; set; }

    public double DocEmbValCom { get; set; }

    public DateTime DocEmbFecPar { get; set; }

    public decimal DocEmbParidad { get; set; }

    public double DocEmbCosDir { get; set; }

    public double MonFuncTasaCambio { get; set; }

    public double MonFuncMonto { get; set; }

    public string DocEmbObser { get; set; } = null!;

    public decimal PConceptoImpId { get; set; }

    public byte IndContabilizaConcepto { get; set; }

    public byte IndAfectaCostoConcepto { get; set; }

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

    public decimal PMovLlgId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PCondPagoId { get; set; }

    public DateTime DocFechaVenc { get; set; }

    public double PorcIva { get; set; }

    public double MontoIva { get; set; }

    public double MontoFuncIva { get; set; }

    public decimal PMovCceId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
