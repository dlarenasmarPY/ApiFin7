using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTCtaUserResponsable
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCfgPreId { get; set; }

    public decimal PCtaId { get; set; }

    public string CtaNombre { get; set; } = null!;

    public string FldUserCode { get; set; } = null!;
}
