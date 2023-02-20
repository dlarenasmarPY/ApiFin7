using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTCambioSujetoDetGlo
{
    public decimal PCambioSujetoCabId { get; set; }

    public decimal PCambioSujetoDetId { get; set; }

    public short DlgLinea { get; set; }

    public byte DlgTipoGlosa { get; set; }

    public string DlgGlosaItem { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
