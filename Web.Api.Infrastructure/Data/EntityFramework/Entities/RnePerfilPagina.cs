using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RnePerfilPagina
{
    public long Numpfi { get; set; }

    public long Numpag { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
