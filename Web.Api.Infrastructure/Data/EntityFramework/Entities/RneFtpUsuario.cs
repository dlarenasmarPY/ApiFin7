using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneFtpUsuario
{
    public long Numusu { get; set; }

    public long Numftp { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }
}
