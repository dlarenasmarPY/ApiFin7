using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneRelacionTabla
{
    public long Numrel { get; set; }

    public string Nomtab { get; set; } = null!;

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }

    public string? Indblo { get; set; }

    public string? Oridat { get; set; }
}
