using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RnePerfil
{
    public long Numpfi { get; set; }

    public string? Despfi { get; set; }

    public string? Indblo { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
