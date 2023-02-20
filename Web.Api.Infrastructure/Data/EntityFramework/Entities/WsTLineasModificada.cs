using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WsTLineasModificada
{
    public decimal POpeLogtCabId { get; set; }

    public string TipoRecepcion { get; set; } = null!;

    public int Linea { get; set; }
}
