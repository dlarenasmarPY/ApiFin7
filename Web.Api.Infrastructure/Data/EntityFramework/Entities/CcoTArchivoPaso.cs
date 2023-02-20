using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTArchivoPaso
{
    public decimal ArchCcoPasoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PFrmCcoId { get; set; }

    public string ArchCcoPasoArchivo { get; set; } = null!;

    public string ArchCcoPasoOwner { get; set; } = null!;

    public string IndTipoReg { get; set; } = null!;

    public string ArchCcoPasoRegistro { get; set; } = null!;
}
