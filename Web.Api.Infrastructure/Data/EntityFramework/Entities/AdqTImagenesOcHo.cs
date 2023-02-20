using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTImagenesOcHo
{
    public decimal PEmpId { get; set; }

    public byte IndTipoImpresion { get; set; }

    public string IdUsuario { get; set; } = null!;

    public byte Posicion { get; set; }

    public double Logo1 { get; set; }

    public double Firma1 { get; set; }

    public string Nombre1 { get; set; } = null!;
}
