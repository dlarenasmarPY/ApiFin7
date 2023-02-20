using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadAuditorium
{
    public decimal EntAuditoriaId { get; set; }

    public decimal PEntId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal PEntSucId { get; set; }

    public DateTime EntAudFechaMod { get; set; }

    public string EntAudUsuario { get; set; } = null!;

    public string EntAudAccion { get; set; } = null!;

    public string EntAudCampoAfectado { get; set; } = null!;

    public string EntAudDatoAntiguo { get; set; } = null!;

    public string EntAudDatoNuevo { get; set; } = null!;

    public decimal PEntDirId { get; set; }

    public decimal PEntConId { get; set; }
}
