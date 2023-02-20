using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneAgrupacion
{
    public long Numagp { get; set; }

    public string? Nomagp { get; set; }

    public string? Indblo { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }
}
