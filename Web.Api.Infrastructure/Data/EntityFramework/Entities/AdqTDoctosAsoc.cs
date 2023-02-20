using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTDoctosAsoc
{
    public decimal POpeLogtCabId { get; set; }

    public short PTdoId { get; set; }

    public int Folio { get; set; }

    public DateTime Fecha { get; set; }

    public string Descripcion { get; set; } = null!;
}
