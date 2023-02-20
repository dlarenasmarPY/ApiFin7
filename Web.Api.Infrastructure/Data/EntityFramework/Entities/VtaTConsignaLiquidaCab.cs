using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConsignaLiquidaCab
{
    public decimal ConsignaLiquidaCabId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public short LccCorrelativo { get; set; }

    public DateTime LccFecDocto { get; set; }

    public string LccReferenciaDocto { get; set; } = null!;

    public DateTime LccFecPagoAcordado { get; set; }

    public byte TpdTipoParidad { get; set; }

    public double LccValorParidad { get; set; }

    public DateTime FechaParidad { get; set; }

    public string LccObservacion { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string CodOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
