using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTCertificacion
{
    public decimal PDoctoLegalCabId { get; set; }

    public string CertCaso { get; set; } = null!;

    public int DlcFolioDocto { get; set; }

    public DateTime DlcFecDocto { get; set; }
}
