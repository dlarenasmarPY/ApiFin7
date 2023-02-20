using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTFormaAtencion
{
    public byte FormaAtencionCod { get; set; }

    public string FormaAtencionDes { get; set; } = null!;
}
