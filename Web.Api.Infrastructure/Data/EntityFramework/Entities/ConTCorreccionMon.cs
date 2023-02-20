using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCorreccionMon
{
    public short EjeAno { get; set; }

    public int PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public short TesTdoId { get; set; }

    public int TesDocNumInterno { get; set; }

    public DateTime FechaCorrMon { get; set; }
}
