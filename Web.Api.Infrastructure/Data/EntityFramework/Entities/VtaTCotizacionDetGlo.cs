using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTCotizacionDetGlo
{
    public decimal PCotizacionDetId { get; set; }

    public decimal PCotizacionCabId { get; set; }

    public short DvgLinea { get; set; }

    public string DvgGlosaItem { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
