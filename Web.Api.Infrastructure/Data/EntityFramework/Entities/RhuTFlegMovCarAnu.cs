using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegMovCarAnu
{
    public decimal FlegManId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal FlegManTipo { get; set; }

    public DateTime FlegManFecInicio { get; set; }

    public DateTime FlegManFecTermino { get; set; }

    public double? FlegManDias { get; set; }

    public int FlegManCertificado { get; set; }

    public string FlegManMotivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte FlegMcaTpDias { get; set; }

    public byte FlegMcaJornada { get; set; }

    public virtual RhuTParItem FlegManTipoNavigation { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;
}
