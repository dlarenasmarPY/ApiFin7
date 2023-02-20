using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelTsolicitud
{
    public decimal IdSolicitud { get; set; }

    public string TipoSolicitud { get; set; } = null!;

    public DateTime FecSolicitud { get; set; }

    public DateTime FecEstimadaTermino { get; set; }

    public DateTime? FecTermino { get; set; }

    public decimal? PEmpId { get; set; }

    public short? DivCodigo { get; set; }

    public short? UniCodigo { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PItmMotSolId { get; set; }

    public string CodEstadoSsolicitud { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public decimal? PCoordinadorSelId { get; set; }

    public decimal PCreId { get; set; }

    public string SelOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTSelObservacion> RhuTSelObservacions { get; } = new List<RhuTSelObservacion>();

    public virtual ICollection<RhuTSelTsolicitudDet> RhuTSelTsolicitudDets { get; } = new List<RhuTSelTsolicitudDet>();
}
