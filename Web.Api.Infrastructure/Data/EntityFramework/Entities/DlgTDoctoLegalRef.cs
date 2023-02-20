using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalRef
{
    public byte DlrTipoReferencia { get; set; }

    public decimal PDoctoLegalCabOid { get; set; }

    public decimal PDoctoLegalCabFid { get; set; }

    public double DlrMtoAfecto { get; set; }

    public double DlrMtoAfectoLocal { get; set; }

    public double DlrMtoExento { get; set; }

    public double DlrMtoExentoLocal { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public double DlrMtoAsignado { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
