using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTProyCalPeriodo
{
    public decimal PEmpId { get; set; }

    public short PerId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public string PerGlosa { get; set; } = null!;

    public string PerGlosaCorta { get; set; } = null!;

    public DateTime PerFecInicio { get; set; }

    public DateTime PerFecTermino { get; set; }

    public double AfiIndBasePer { get; set; }
}
