using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpuesto
{
    public decimal ImpuestoId { get; set; }

    public string ImpuestoDes { get; set; } = null!;

    public decimal PTipoImpId { get; set; }

    public double ImpuestoPorc { get; set; }

    public decimal PCtaId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte Honorarios { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PMonedaId { get; set; }

    public short IsiiCodigo { get; set; }

    public virtual ICollection<LogTImpuestosProducto> LogTImpuestosProductos { get; } = new List<LogTImpuestosProducto>();

    public virtual LogTTipoImpuesto PTipoImp { get; set; } = null!;
}
