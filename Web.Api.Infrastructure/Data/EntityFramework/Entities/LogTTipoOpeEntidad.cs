using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTipoOpeEntidad
{
    public decimal PEmpId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PTipoOpeContId { get; set; }

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual LogTTipoOperacione PTipoOpe { get; set; } = null!;

    public virtual ConTTipoOperacion PTipoOpeCont { get; set; } = null!;
}
