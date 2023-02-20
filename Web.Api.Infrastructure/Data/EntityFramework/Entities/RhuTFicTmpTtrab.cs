using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicTmpTtrab
{
    public string CodOwner { get; set; } = null!;

    public decimal PFicPerId { get; set; }

    public string EntRut { get; set; } = null!;

    public string NombreTrabajador { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public string DivGlosa { get; set; } = null!;

    public string CreNombre { get; set; } = null!;

    public string LugDescripcion { get; set; } = null!;

    public decimal PCtoId { get; set; }
}
