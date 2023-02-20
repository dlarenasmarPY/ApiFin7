using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTClasificacion
{
    public byte ClasificaId { get; set; }

    public string Descripcion { get; set; } = null!;
}
