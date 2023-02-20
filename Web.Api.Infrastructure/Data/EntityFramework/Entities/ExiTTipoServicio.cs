using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoServicio
{
    public byte TseCodigo { get; set; }

    public string TseGlosa { get; set; } = null!;
}
