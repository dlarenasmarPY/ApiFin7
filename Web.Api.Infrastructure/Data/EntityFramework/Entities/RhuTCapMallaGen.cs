﻿using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapMallaGen
{
    public decimal CapMalGenId { get; set; }

    public short EjeAno { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PCapMallaId { get; set; }

    public decimal PCapEjeNomId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapMallaCur PCapMalla { get; set; } = null!;
}
