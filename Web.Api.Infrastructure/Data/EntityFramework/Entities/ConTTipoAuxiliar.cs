using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTTipoAuxiliar
{
    public byte TauId { get; set; }

    public string TauGlosa { get; set; } = null!;
}
