using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTipoCompra
{
    public byte TipoCompraCod { get; set; }

    public string TipoCompraDes { get; set; } = null!;
}
