using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTConfiguracionActi
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short OpeCodAporte { get; set; }

    public short OpeCodRescate { get; set; }

    public decimal CtaIdGastos { get; set; }

    public decimal CtaIdPuente { get; set; }

    public decimal CtaIdEfectivo { get; set; }

    public short TdoId { get; set; }

    public int CfiCodigo { get; set; }
}
