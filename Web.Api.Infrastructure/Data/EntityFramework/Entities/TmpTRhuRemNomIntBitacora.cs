using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemNomIntBitacora
{
    public decimal PNomConcId { get; set; }

    public string NcnImpNombreArchivo { get; set; } = null!;

    public DateTime NcnImpBitFec { get; set; }

    public byte NcnImpBitEstado { get; set; }

    public string NcnImpBitUsuario { get; set; } = null!;
}
