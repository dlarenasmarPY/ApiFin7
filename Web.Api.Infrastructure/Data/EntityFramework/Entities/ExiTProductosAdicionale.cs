using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosAdicionale
{
    public decimal ProductoAdicionalId { get; set; }

    public byte TipoItem { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PProductoTransformacionId { get; set; }

    public decimal PTipoProductoId { get; set; }

    public byte IndGranel { get; set; }

    public byte IndTransformacion { get; set; }

    public string CalcNumeroPallet { get; set; } = null!;

    public double CantidadEntrega { get; set; }

    public int PalletxLote { get; set; }

    public string Pallet { get; set; } = null!;

    public string Lote { get; set; } = null!;

    public int CorrPalletxLote { get; set; }

    public short DuracionProducto { get; set; }

    public string UnidadTiempo { get; set; } = null!;

    public double CostoEstandar { get; set; }

    public double CostoEstandarTrib { get; set; }

    public double CostoEstandarSinCorr { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short NumForTransf { get; set; }

    public string Brix { get; set; } = null!;

    public string Clave1 { get; set; } = null!;

    public string Clave2 { get; set; } = null!;

    public double CostoUltimoCierre { get; set; }

    public double CostoReposicion { get; set; }
}
