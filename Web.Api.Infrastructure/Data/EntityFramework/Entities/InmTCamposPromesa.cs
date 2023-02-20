using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCamposPromesa
{
    public decimal CampoId { get; set; }

    public string Descripcion { get; set; } = null!;

    public string CamposTab { get; set; } = null!;
}
