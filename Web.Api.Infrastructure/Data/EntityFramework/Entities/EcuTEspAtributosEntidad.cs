using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class EcuTEspAtributosEntidad
{
    public decimal PEntId { get; set; }

    public string CodDinardap { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string OrigenEnt { get; set; } = null!;

    public string EstCivil { get; set; } = null!;
}
