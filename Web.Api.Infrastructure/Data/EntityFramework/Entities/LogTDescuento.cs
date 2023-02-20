using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTDescuento
{
    public decimal DescuentoId { get; set; }

    public decimal PEmpId { get; set; }

    public byte SisCodOri { get; set; }

    public byte TipoCliente { get; set; }

    public decimal PLineaProdId { get; set; }

    public decimal PMarcaId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PCategoriaId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public double TotalDesctoPorc { get; set; }

    public string GlosaLarga { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
