using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTPersonaAutorizadum
{
    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public DateTime PauFecVigDesde { get; set; }

    public DateTime PauFecVigHasta { get; set; }

    public string PauRazonSocialCert { get; set; } = null!;

    public string PauPassword { get; set; } = null!;

    public byte PauChkAnula { get; set; }

    public byte PauChkFirma { get; set; }

    public byte PauChkEnvia { get; set; }

    public byte PauChkGenera { get; set; }
}
