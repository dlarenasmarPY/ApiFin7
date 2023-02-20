using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTMarca
{
    public decimal MarcaId { get; set; }

    public string MarcaProducto { get; set; } = null!;

    public string DescripcionMarca { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public byte IndicaSerie { get; set; }
}
