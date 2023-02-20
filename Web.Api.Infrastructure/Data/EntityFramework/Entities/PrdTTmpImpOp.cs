using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpImpOp
{
    public string CodOwner { get; set; } = null!;

    public int NumeroRef { get; set; }

    public string SeccionCod { get; set; } = null!;

    public decimal PTprId { get; set; }

    public int BodegaCod { get; set; }

    public DateTime FechaProceso { get; set; }

    public DateTime FechaEntrega { get; set; }

    public int Item { get; set; }

    public string ProductoCod { get; set; } = null!;

    public short NumFormula { get; set; }

    public string UnidadMedCod { get; set; } = null!;

    public double Cantidad { get; set; }

    public short CodError { get; set; }

    public string ErrGlosa { get; set; } = null!;
}
