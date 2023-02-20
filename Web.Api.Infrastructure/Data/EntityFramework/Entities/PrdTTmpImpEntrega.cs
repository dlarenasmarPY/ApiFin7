using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpImpEntrega
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string TurnoCod { get; set; } = null!;

    public string MaquinaCod { get; set; } = null!;

    public string ProductoCod { get; set; } = null!;

    public string LoteProductoCod { get; set; } = null!;

    public int NumeroLoteAgrupa { get; set; }

    public double Cantidad { get; set; }

    public string Observacion { get; set; } = null!;

    public DateTime FechaIngresoHora { get; set; }
}
