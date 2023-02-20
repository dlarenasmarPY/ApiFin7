using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTTipoNomina
{
    public byte TipNomCod { get; set; }

    public string TipNomGlosa { get; set; } = null!;

    public byte TipNomTipo { get; set; }

    public byte TipNomInsCco { get; set; }

    public byte TipNomGeneraArchivo { get; set; }

    public byte TipNomConfirmacion { get; set; }

    public byte IndEnvio { get; set; }

    public short EstDocCod { get; set; }

    public byte TipUbiCod { get; set; }
}
