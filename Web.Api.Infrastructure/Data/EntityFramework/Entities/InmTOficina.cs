using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTOficina
{
    public short CodOficina { get; set; }

    public string GlosaOficina { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int CmuCodigo { get; set; }

    public string Ciudad { get; set; } = null!;

    public string Telefono { get; set; } = null!;
}
