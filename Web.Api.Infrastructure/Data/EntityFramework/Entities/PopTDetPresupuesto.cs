using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTDetPresupuesto
{
    public decimal DetPreOpeId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PCfgPreId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PPerId { get; set; }

    public decimal MontoPpto { get; set; }

    public decimal MontoProyectado { get; set; }
}
