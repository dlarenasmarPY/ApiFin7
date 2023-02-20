using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapEjeNomina
{
    public decimal CapEjeNomId { get; set; }

    public decimal PCapEjeId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal CapEjeNomNotasId { get; set; }

    public short CapEjeNomAsistencia { get; set; }

    public decimal CapEjeNomMtoVia { get; set; }

    public decimal CapEjeNomMtoTra { get; set; }

    public short CapEjeNomFranquicia { get; set; }

    public decimal CapEjeNomMtoSen { get; set; }

    public decimal CapEjeNomMtoEmp { get; set; }

    public string CapEjeNomObserv { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapParNota CapEjeNomNotas { get; set; } = null!;

    public virtual RhuTCapEjecucion PCapEje { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;
}
