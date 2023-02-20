using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalFol
{
    public decimal PEmpId { get; set; }

    public short TdoId { get; set; }

    public int DlcFolioDocto { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
