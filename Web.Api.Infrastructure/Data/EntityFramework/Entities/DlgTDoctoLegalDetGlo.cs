using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalDetGlo
{
    public decimal PDoctoLegalCabId { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public short DlgLinea { get; set; }

    public byte DlgTipoGlosa { get; set; }

    public string DlgGlosaItem { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public string DlgGlosaLarga { get; set; } = null!;
}
