using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTMotivo
{
    public byte Motivo { get; set; }

    public string Descripcion { get; set; } = null!;

    public short Tipo { get; set; }
}
