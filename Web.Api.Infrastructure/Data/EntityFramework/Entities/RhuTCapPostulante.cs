using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapPostulante
{
    public decimal CapPostId { get; set; }

    public DateTime CapPosFechaSol { get; set; }

    public decimal PCtoSecId { get; set; }

    public string CapPosMotivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCapPostulantesDet> RhuTCapPostulantesDets { get; } = new List<RhuTCapPostulantesDet>();
}
