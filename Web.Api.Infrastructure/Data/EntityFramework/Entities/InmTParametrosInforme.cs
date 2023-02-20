using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTParametrosInforme
{
    public string Usuario { get; set; } = null!;

    public string InmNombreInforme { get; set; } = null!;

    public string InmParamInforme { get; set; } = null!;
}
