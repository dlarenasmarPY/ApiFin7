using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieSociosConv
{
    public decimal BieSocConvId { get; set; }

    public decimal PBieSocId { get; set; }

    public decimal PBieConvId { get; set; }

    public DateTime FecVigencia { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal ValMoneda { get; set; }

    public decimal ValCantidad { get; set; }

    public decimal ValConvenio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTBieConvenio PBieConv { get; set; } = null!;

    public virtual RhuTBieSocio PBieSoc { get; set; } = null!;
}
