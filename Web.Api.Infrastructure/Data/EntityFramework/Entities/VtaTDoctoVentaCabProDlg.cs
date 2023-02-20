using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaCabProDlg
{
    public decimal PDoctoVentaCabProId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
