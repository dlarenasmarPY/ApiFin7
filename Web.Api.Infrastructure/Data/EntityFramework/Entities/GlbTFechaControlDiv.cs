﻿using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFechaControlDiv
{
    public decimal FechaControlDivId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short EjeAno { get; set; }

    public byte SisCodOri { get; set; }

    public DateTime CfgConFechaMinimaImp { get; set; }

    public DateTime CfgConFechaMaximaImp { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
