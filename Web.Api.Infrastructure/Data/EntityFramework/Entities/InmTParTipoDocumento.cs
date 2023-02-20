using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTParTipoDocumento
{
    public int CodTipoDocumento { get; set; }

    public string Descripcion { get; set; } = null!;
}
