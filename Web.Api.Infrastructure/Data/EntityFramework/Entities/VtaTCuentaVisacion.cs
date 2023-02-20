using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTCuentaVisacion
{
    public decimal PEmpId { get; set; }

    public decimal PCtaId { get; set; }

    public byte TcvCodigo { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
