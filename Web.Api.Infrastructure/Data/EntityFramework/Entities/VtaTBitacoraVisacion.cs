using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTBitacoraVisacion
{
    public decimal BitacoraVisacionId { get; set; }

    public short BidOrigenDato { get; set; }

    public decimal PCabReferenciaId { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public string BidGlosa { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte BidIndVigente { get; set; }

    public short TpeCodigo { get; set; }

    public double BidMonto { get; set; }

    public decimal PGlbMotivoId { get; set; }

    public string BidGlosaMotivo { get; set; } = null!;

    public decimal PEmpId { get; set; }
}
