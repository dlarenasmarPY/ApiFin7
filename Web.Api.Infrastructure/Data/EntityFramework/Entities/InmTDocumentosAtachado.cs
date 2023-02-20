using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTDocumentosAtachado
{
    public decimal DocumentosId { get; set; }

    public string CliRut { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public string Glosa { get; set; } = null!;

    public string NombreArchivo { get; set; } = null!;

    public string CodReferencia { get; set; } = null!;

    public int NumReferencia { get; set; }

    public decimal PTprId { get; set; }
}
