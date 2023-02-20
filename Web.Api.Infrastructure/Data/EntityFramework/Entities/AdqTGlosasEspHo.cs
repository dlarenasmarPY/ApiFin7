using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTGlosasEspHo
{
    public decimal PEmpId { get; set; }

    public decimal POcCabId { get; set; }

    public string GlosaHo1 { get; set; } = null!;

    public string GlosaHo2 { get; set; } = null!;

    public string GlosaHo3 { get; set; } = null!;

    public string GlosaHo4 { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;
}
