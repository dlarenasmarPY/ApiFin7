using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTSolicitudAjusteCabDlg
{
    public decimal PSolicitudAjusteCabId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public double SacMtoAsignado { get; set; }

    public double SacMtoAsignadoDlg { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
