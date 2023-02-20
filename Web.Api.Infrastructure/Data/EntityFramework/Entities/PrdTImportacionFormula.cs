using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTImportacionFormula
{
    public string CodOwner { get; set; } = null!;

    public string CodigoArticulo { get; set; } = null!;

    public short NumFormula { get; set; }

    public string Descrip { get; set; } = null!;

    public string UnidadMedCod { get; set; } = null!;

    public byte IndVirtual { get; set; }

    public short CodError { get; set; }

    public string ErrGlosa { get; set; } = null!;
}
