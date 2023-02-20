using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoFuncionalidad
{
    public byte TfuCodigo { get; set; }

    public string TfuGlosa { get; set; } = null!;

    public byte TfuUsaVisacion { get; set; }
}
