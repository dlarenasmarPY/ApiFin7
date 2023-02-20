using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTRecepcionDetRef
{
    public decimal RecepcionDetRefId { get; set; }

    public decimal PRecepcionDetId { get; set; }

    public decimal PTdoReferenciaSiiId { get; set; }

    public string DlcFolioDocRef { get; set; } = null!;

    public DateTime DlcFecDocRef { get; set; }

    public byte DlcIndDocRef { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
