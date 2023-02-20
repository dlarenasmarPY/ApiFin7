using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConsignaLiquidaCabDoc
{
    public decimal PConsignaLiquidaCabId { get; set; }

    public string LcdObservacion { get; set; } = null!;

    public string LcdRutaDocto { get; set; } = null!;

    public string LcdArchivoDocto { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
