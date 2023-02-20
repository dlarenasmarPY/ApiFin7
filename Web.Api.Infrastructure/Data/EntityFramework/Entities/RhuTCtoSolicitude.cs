using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoSolicitude
{
    public decimal CtoSolId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PItmParId { get; set; }

    public DateTime CtoSolFecInicio { get; set; }

    public short CtoSolSecuencia { get; set; }

    public DateTime CtoSolFecha { get; set; }

    public DateTime CtoSolFecTermino { get; set; }

    public short CtoSolDias { get; set; }

    public decimal PItmCtoSolEstId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParItem PItmCtoSolEst { get; set; } = null!;

    public virtual RhuTParItem PItmPar { get; set; } = null!;
}
