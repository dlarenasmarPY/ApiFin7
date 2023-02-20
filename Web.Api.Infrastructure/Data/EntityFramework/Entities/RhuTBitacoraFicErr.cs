using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBitacoraFicErr
{
    public string BitFicArchivo { get; set; } = null!;

    public short BitFicLinea { get; set; }

    public string BitFicGlosaErr { get; set; } = null!;

    public string IdFuncionUlt { get; set; } = null!;
}
