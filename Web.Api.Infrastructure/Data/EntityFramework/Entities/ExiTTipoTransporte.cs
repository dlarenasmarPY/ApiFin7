using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoTransporte
{
    public byte TipoTranspCod { get; set; }

    public string TipoTranspDes { get; set; } = null!;
}
