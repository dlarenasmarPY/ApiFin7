using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaDetGlo
{
    public decimal PDoctoVentaDetId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public short DvgLinea { get; set; }

    public string DvgGlosaItem { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PDoctoVentaCabProId { get; set; }

    public byte DlgTipoGlosa { get; set; }
}
