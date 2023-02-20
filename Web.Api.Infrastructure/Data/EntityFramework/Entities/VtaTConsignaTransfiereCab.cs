using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConsignaTransfiereCab
{
    public decimal ConsignaTransfiereCabId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public short CtcCorrelativo { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public DateTime CtcFecDocto { get; set; }

    public string CtcReferenciaDocto { get; set; } = null!;

    public DateTime CtcFecPagoAcordado { get; set; }

    public string CtcReferenciaFecPago { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public byte TpdTipoParidad { get; set; }

    public double CtcValorParidad { get; set; }

    public DateTime FechaParidad { get; set; }

    public string CtcObservacion { get; set; } = null!;

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
