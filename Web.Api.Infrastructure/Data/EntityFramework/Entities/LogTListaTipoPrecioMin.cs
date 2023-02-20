using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTListaTipoPrecioMin
{
    public byte TipoPrecio { get; set; }

    public string TipoPrecioDes { get; set; } = null!;
}
