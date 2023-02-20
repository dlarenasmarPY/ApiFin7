using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTUsuarioTipoOpe
{
    public string FldUserCode { get; set; } = null!;

    public decimal PTipoOpeId { get; set; }

    public decimal PTipoOpeIdDefault { get; set; }

    public virtual LogTTipoOperacione PTipoOpe { get; set; } = null!;
}
