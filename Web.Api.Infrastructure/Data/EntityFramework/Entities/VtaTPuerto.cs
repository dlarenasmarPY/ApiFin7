using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTPuerto
{
    public decimal PuertoId { get; set; }

    public string NombrePuerto { get; set; } = null!;

    public decimal PPaisId { get; set; }

    public short PuertoCodigoSii { get; set; }
}
