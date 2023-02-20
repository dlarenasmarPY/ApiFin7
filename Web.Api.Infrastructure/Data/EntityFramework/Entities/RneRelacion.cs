using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneRelacion
{
    public long Numrel { get; set; }

    public string? Nomrel { get; set; }

    public long Numbas { get; set; }

    public string? Indblo { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }
}
