using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTTipoComprobante
{
    public decimal PEmpId { get; set; }

    public short TcoId { get; set; }

    public string TcoGlosa { get; set; } = null!;

    public string TcoGlosaCorta { get; set; } = null!;

    public decimal PCorId { get; set; }

    public byte TcoTipoFuncion { get; set; }

    public DateTime TcoFecVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
