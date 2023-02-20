using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTPlanCentro
{
    public decimal PdcId { get; set; }

    public string PdcNomPlan { get; set; } = null!;

    public byte PdcCantidadNiveles { get; set; }

    public string PdcNomNivel1 { get; set; } = null!;

    public string PdcNomNivel2 { get; set; } = null!;

    public string PdcNomNivel3 { get; set; } = null!;

    public string PdcNomNivel4 { get; set; } = null!;

    public string PdcNomNivel5 { get; set; } = null!;

    public string PdcNomNivel6 { get; set; } = null!;

    public string PdcNomNivel7 { get; set; } = null!;

    public string PdcOwner { get; set; } = null!;
}
