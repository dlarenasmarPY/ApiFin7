using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTDetIntegracion
{
    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CfgNumId { get; set; }

    public int CreCodigo { get; set; }

    public int CtaCodigo { get; set; }

    public short PerId { get; set; }

    public decimal MontoPpto { get; set; }

    public string GlosaLineaDetalle { get; set; } = null!;
}
