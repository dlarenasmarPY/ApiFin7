using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaCalendario
{
    public decimal IdCalendario { get; set; }

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short SeqProceso { get; set; }

    public string GlosaCalendario { get; set; } = null!;

    public DateTime? FechaInicioPlan { get; set; }

    public DateTime FechaInicioEval { get; set; }

    public DateTime FechaCierreEval { get; set; }

    public DateTime? Fecha1erRecon { get; set; }

    public DateTime? FechaInicioApelacion { get; set; }

    public DateTime? FechaCierreApelacion { get; set; }

    public DateTime? FechaUltRecon { get; set; }

    public decimal PItmEstCal { get; set; }

    public DateTime FechaEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTEvaCalendarioCategorium> RhuTEvaCalendarioCategoria { get; } = new List<RhuTEvaCalendarioCategorium>();
}
