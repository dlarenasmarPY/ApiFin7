using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTipoConvenio
{
    public short TcpCodigo { get; set; }

    public string TcpGlosa { get; set; } = null!;
}
