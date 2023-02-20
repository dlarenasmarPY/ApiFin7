using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelRefPostulante
{
    public decimal IdReferenciaPostulante { get; set; }

    public decimal PidPostulante { get; set; }

    public decimal PAntLabId { get; set; }

    public string SelRefPostulante { get; set; } = null!;

    public DateTime FecReferencia { get; set; }

    public string GlosaObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicAntLaborale PAntLab { get; set; } = null!;

    public virtual RhuTSelPostulante PidPostulanteNavigation { get; set; } = null!;
}
