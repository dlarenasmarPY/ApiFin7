using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoTmpTaud
{
    public DateTime SadFecha { get; set; }

    public string SadUsuario { get; set; } = null!;

    public string SadCampo { get; set; } = null!;

    public decimal SadIdTabla { get; set; }

    public string SadValorAntiguo { get; set; } = null!;

    public string SadValorNuevo { get; set; } = null!;
}
