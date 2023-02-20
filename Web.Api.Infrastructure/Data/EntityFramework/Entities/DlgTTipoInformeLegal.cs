using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTTipoInformeLegal
{
    public decimal PEmpId { get; set; }

    public short TdoId { get; set; }

    public string TilNombreRdl { get; set; } = null!;

    public string TilNombreReporte { get; set; } = null!;

    public decimal PEfoId { get; set; }

    public string TilNombreImpresora { get; set; } = null!;

    public byte TilNroCopiaOriginal { get; set; }

    public byte TilNroCopiaCedible { get; set; }

    public byte TilTipoImpresion { get; set; }
}
