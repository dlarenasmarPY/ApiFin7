using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTDetalleMensaje
{
    public decimal DetMenId { get; set; }

    public decimal PCabMenId { get; set; }

    public string DetMenPara { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
