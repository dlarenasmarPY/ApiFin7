using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTEntidadCobTipoMovto
{
    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public string TmcId { get; set; } = null!;

    public string TmcGlosa { get; set; } = null!;

    public byte IndIngresoEgreso { get; set; }

    public byte TipoMovCobranza { get; set; }

    public short ScoId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
