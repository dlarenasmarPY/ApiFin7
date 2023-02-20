using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParAuditorium
{
    public decimal SadId { get; set; }

    public DateTime SadFecha { get; set; }

    public string SadUsuario { get; set; } = null!;

    public string SadOperacion { get; set; } = null!;

    public string SadTabla { get; set; } = null!;

    public string SadCampo { get; set; } = null!;

    public decimal SadIdTabla { get; set; }

    public string SadValorAntiguo { get; set; } = null!;

    public string SadValorNuevo { get; set; } = null!;
}
