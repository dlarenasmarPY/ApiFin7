using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTAudObjetosFin
{
    public decimal AuditoriaId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PPctaId { get; set; }

    public decimal PPcreId { get; set; }

    public DateTime AudFecha { get; set; }

    public string AudUsuario { get; set; } = null!;

    public string AudAccion { get; set; } = null!;

    public string AudCampoAfectado { get; set; } = null!;

    public string AudDatoAntiguo { get; set; } = null!;

    public string AudDatoNuevo { get; set; } = null!;
}
