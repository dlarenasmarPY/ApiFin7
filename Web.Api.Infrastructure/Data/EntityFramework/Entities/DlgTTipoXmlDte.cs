using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTTipoXmlDte
{
    public byte TipoXmlDte { get; set; }

    public string TipoXmlDteglosa { get; set; } = null!;

    public string TagXmlDte { get; set; } = null!;
}
