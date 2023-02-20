using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTErroresCargaMasiva
{
    public string IdUsuario { get; set; } = null!;

    public int Linea { get; set; }

    public string ProductoCod { get; set; } = null!;

    public string ServicioCod { get; set; } = null!;

    public string GlosaMensajeValidacion { get; set; } = null!;
}
