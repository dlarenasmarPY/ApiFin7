using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqCausalReal
{
    public decimal FnqCauReaId { get; set; }

    public short FnqCauReaCodigo { get; set; }

    public string FnqCauReaGlosa { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCtoConfiguracion> RhuTCtoConfiguracions { get; } = new List<RhuTCtoConfiguracion>();

    public virtual ICollection<RhuTFnqSolicitudDet> RhuTFnqSolicitudDets { get; } = new List<RhuTFnqSolicitudDet>();
}
