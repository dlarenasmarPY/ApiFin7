using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegMovCargo
{
    public decimal FlegMcaId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal FlegMcaTipo { get; set; }

    public DateTime FlegMcaFecInicio { get; set; }

    public DateTime FlegMcaFecTermino { get; set; }

    public double? FlegMcaDias { get; set; }

    public int FlegMcaCertificado { get; set; }

    public string FlegMcaMotivo { get; set; } = null!;

    public decimal FlegMcaEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte FlegMcaTpDias { get; set; }

    public byte FlegMcaJornada { get; set; }

    public byte FlegMcaIndRecep { get; set; }

    public virtual RhuTParItem FlegMcaEstadoNavigation { get; set; } = null!;

    public virtual RhuTParItem FlegMcaTipoNavigation { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual ICollection<RhuTFlegMovPeriodo> RhuTFlegMovPeriodos { get; } = new List<RhuTFlegMovPeriodo>();
}
