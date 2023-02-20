using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelDocumentoPersona
{
    public decimal IdDocumentoPersona { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PItmDocSelId { get; set; }

    public DateTime FecEmision { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PidSolicitudDetalle { get; set; }

    public string CodEstadoDctoPersona { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public string DocumentoFisico { get; set; } = null!;

    public string GlosaObservacion { get; set; } = null!;

    public decimal PidNotificacion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
