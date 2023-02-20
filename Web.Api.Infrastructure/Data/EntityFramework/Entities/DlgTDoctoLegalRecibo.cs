using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalRecibo
{
    public decimal DoctoLegalReciboId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public int DlrNumDocto { get; set; }

    public string DlrReciboCliente { get; set; } = null!;

    public string DlrXmlRecibo { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PDoctoLegalCabIdReal { get; set; }
}
