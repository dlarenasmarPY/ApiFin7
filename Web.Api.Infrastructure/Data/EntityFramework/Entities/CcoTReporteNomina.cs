using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTReporteNomina
{
    public byte RepNomCod { get; set; }

    public string RepNomGlosa { get; set; } = null!;

    public string RepNomPlantilla { get; set; } = null!;

    public byte RepNomIndNomina { get; set; }

    public byte IndEnvio { get; set; }
}
