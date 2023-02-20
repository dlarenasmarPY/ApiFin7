using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoGrupoVentum
{
    public decimal PEmpId { get; set; }

    public short TgvId { get; set; }

    public string TgvGlosa { get; set; } = null!;

    public int TgvSup { get; set; }
}
