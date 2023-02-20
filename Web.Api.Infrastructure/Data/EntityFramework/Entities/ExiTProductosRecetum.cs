using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosRecetum
{
    public decimal ProductoRecId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PTipoComponenteId { get; set; }

    public byte IndCompuesto { get; set; }

    public decimal PProductoRecetaId { get; set; }

    public double RecCantidadppm { get; set; }

    public double RecConcentracionPorc { get; set; }

    public double RecFactorDistribucion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ExiTProducto PProducto { get; set; } = null!;

    public virtual ExiTProducto PProductoReceta { get; set; } = null!;
}
