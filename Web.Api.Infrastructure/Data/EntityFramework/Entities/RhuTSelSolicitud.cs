using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelSolicitud
{
    public decimal SctId { get; set; }

    public int SctNumSolicitud { get; set; }

    public decimal PItmTpSolicId { get; set; }

    public DateTime SctFecSolicitud { get; set; }

    public DateTime SctFecEstTermino { get; set; }

    public DateTime SctFecTermino { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public decimal PFicPerSolicId { get; set; }

    public decimal PItmTpMotivoId { get; set; }

    public decimal PFicPerCoordId { get; set; }

    public DateTime SctFecEstado { get; set; }

    public decimal PItmEstadoSolId { get; set; }

    public string SctObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual RhuTFicPersona PFicPerCoord { get; set; } = null!;

    public virtual RhuTFicPersona PFicPerSolic { get; set; } = null!;

    public virtual RhuTParItem PItmEstadoSol { get; set; } = null!;

    public virtual RhuTParItem PItmTpMotivo { get; set; } = null!;

    public virtual RhuTParItem PItmTpSolic { get; set; } = null!;

    public virtual ICollection<RhuTSelSolicitudDet> RhuTSelSolicitudDets { get; } = new List<RhuTSelSolicitudDet>();
}
