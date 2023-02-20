using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTCorrelativo
{
    public decimal CorrLogtId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short PerId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public int CorrLogtNum { get; set; }

    public virtual GlbTEmpresa PEmp { get; set; } = null!;
}
