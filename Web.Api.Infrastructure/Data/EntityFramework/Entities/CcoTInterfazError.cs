using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTInterfazError
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PEntCcoId { get; set; }

    public string IntCcoNomArchivo { get; set; } = null!;

    public string IntCcoOwner { get; set; } = null!;

    public decimal PIntCcoId { get; set; }

    public decimal PRecDocDetId { get; set; }

    public string IntCcoGlosaError { get; set; } = null!;
}
