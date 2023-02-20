using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapCursosHor
{
    public decimal CapCurHorId { get; set; }

    public decimal PCapCurCalId { get; set; }

    public short CapHorSeq { get; set; }

    public byte CapHorDia { get; set; }

    public DateTime CapCurHorIni { get; set; }

    public DateTime CapCurHorFin { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCursosCalen PCapCurCal { get; set; } = null!;
}
