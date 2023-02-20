using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTGruposCompra
{
    public decimal PEmpId { get; set; }

    public string GrpCompCod { get; set; } = null!;

    public string GrpCompGlosa { get; set; } = null!;

    public DateTime FechaUltRevision { get; set; }

    public byte DiasParaRevision { get; set; }

    public DateTime FechaProxRevision { get; set; }

    public string EntRut { get; set; } = null!;

    public short DiasDemoraEntrega { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
