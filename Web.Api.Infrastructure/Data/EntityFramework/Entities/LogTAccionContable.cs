using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTAccionContable
{
    public byte AccionContCod { get; set; }

    public string AccionContDes { get; set; } = null!;

    public virtual ICollection<LogTSituacionContable> LogTSituacionContables { get; } = new List<LogTSituacionContable>();
}
