using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WmsTmpDetalleEmbarque
{
    public decimal Pempid { get; set; }

    public short Divcodigo { get; set; }

    public short Unicodigo { get; set; }

    public string Tiporecepcion { get; set; } = null!;

    public decimal PEmbarqueCabId { get; set; }

    public int Linea { get; set; }
}
