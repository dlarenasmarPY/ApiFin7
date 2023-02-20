using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDoctoRef
{
    public decimal POpeLogtCabId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal PDocReferenciaId { get; set; }

    public short TdoId { get; set; }

    public int DlcFolioDocto { get; set; }

    public DateTime DlcFecDocto { get; set; }

    public string LogOwner { get; set; } = null!;

    public decimal POpeLogtDetserlotId { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public decimal POpeLogtDetSerId { get; set; }

    public virtual LogTOperacionesLogtCab POpeLogtCab { get; set; } = null!;
}
