using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class EfeTCtasContable
{
    public decimal PEmpId { get; set; }

    public decimal PCtaId { get; set; }

    public byte EfeFlujoEfe { get; set; }

    public byte EfeActFijo { get; set; }

    public decimal CtaFlujoDebe { get; set; }

    public decimal CtaFlujoHaber { get; set; }
}
