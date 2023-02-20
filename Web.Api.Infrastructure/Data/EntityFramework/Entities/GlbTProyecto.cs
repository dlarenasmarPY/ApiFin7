using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTProyecto
{
    public decimal PryId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string PryGlosa { get; set; } = null!;

    public string FldUserCode { get; set; } = null!;

    public decimal PCreId { get; set; }

    public decimal PEntId { get; set; }

    public DateTime PryFecInicio { get; set; }

    public DateTime PryFecTermino { get; set; }

    public DateTime PryFecVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
