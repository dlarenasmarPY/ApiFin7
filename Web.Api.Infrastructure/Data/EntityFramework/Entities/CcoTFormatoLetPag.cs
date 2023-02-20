using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTFormatoLetPag
{
    public short CcoFormatoCod { get; set; }

    public string CcoFormatoGlosa { get; set; } = null!;

    public byte CcoTipoFormato { get; set; }
}
