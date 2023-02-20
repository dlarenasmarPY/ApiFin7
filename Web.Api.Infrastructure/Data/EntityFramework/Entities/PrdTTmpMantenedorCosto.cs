using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpMantenedorCosto
{
    public string CodOwner { get; set; } = null!;

    public byte TipoRecursoCod { get; set; }

    public string ProductoCod { get; set; } = null!;

    public short PerId { get; set; }

    public double CostoEstandar { get; set; }

    public double CostoEstandarTrib { get; set; }

    public double CostoEstandarSinCorr { get; set; }

    public short CodError { get; set; }

    public string ErrGlosa { get; set; } = null!;
}
