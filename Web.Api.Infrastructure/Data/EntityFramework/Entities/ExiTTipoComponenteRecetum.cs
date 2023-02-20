using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoComponenteRecetum
{
    public decimal TipoComponenteId { get; set; }

    public string TipoComponenteCod { get; set; } = null!;

    public byte IndRecCantidadppm { get; set; }

    public byte IndRecConcentracionPorc { get; set; }

    public byte IndicaCompuestoUnico { get; set; }
}
