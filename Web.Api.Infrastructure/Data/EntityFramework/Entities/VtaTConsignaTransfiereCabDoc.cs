using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTConsignaTransfiereCabDoc
{
    public decimal PConsignaTransfiereCabId { get; set; }

    public string CtdObservacion { get; set; } = null!;

    public string CtdRutaDocto { get; set; } = null!;

    public string CtdArchivoDocto { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
