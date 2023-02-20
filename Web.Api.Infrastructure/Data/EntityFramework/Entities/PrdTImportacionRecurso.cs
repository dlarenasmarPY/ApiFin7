using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTImportacionRecurso
{
    public string CodOwner { get; set; } = null!;

    public string TipoRecurso { get; set; } = null!;

    public string CodigoArticulo { get; set; } = null!;

    public short NumFormula { get; set; }

    public string CodigoRecurso { get; set; } = null!;

    public short NumRecurso { get; set; }

    public double CantidadRec { get; set; }

    public string CantidadRecStr { get; set; } = null!;

    public decimal PorSobreConsumo { get; set; }

    public int SecuenciaFor { get; set; }

    public short CodError { get; set; }

    public string ErrGlosa { get; set; } = null!;
}
