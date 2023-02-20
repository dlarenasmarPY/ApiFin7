using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoPlantum
{
    public int Codigo { get; set; }

    public string Descripcion { get; set; } = null!;
}
