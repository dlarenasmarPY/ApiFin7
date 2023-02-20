using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCierreApertura
{
    public short EjeAno { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCabCompIdCie { get; set; }

    public decimal PCabCompIdApe { get; set; }
}
