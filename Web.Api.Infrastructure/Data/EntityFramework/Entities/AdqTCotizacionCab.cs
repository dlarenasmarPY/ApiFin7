using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionCab
{
    public decimal CotizCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public int NumeroReferencia { get; set; }

    public string ContactoProv { get; set; } = null!;

    public string ReferenciaProv { get; set; } = null!;

    public DateTime FechaMaxCotizacion { get; set; }

    public DateTime FechaMaxRespProv { get; set; }

    public decimal PGlosaId { get; set; }

    public byte ConEstCod { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public byte IndTipoCotizacion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PRolUsuarioId { get; set; }

    public string AdqGlosa { get; set; } = null!;

    public string UsuarioAprobacion { get; set; } = null!;

    public virtual ICollection<AdqTCotizacionCabCom> AdqTCotizacionCabComs { get; } = new List<AdqTCotizacionCabCom>();

    public virtual ICollection<AdqTCotizacionCabFlete> AdqTCotizacionCabFletes { get; } = new List<AdqTCotizacionCabFlete>();

    public virtual ICollection<AdqTCotizacionCabGlosa> AdqTCotizacionCabGlosas { get; } = new List<AdqTCotizacionCabGlosa>();

    public virtual ICollection<AdqTCotizacionDet> AdqTCotizacionDets { get; } = new List<AdqTCotizacionDet>();

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual GlbTEntidadSucursal PEntSuc { get; set; } = null!;
}
