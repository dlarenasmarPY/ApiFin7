using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCorreccionMonAux
{
    public short EjeAno { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public short OpeCod { get; set; }

    public decimal PCabOpeId { get; set; }

    public DateTime FechaCorrMon { get; set; }
}
