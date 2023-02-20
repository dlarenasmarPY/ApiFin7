using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmtCotPruebaImagene
{
    public decimal ImagenId { get; set; }

    public decimal Correlativo { get; set; }

    public string Depto { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public byte[] Imagen { get; set; } = null!;

    public string Precio { get; set; } = null!;
}
