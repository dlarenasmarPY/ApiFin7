using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTInventarioDetProducto
{
    public int Linea { get; set; }

    public decimal InvDetProdId { get; set; }

    public decimal PInvCabId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PProductoId { get; set; }

    public string ProductoDes { get; set; } = null!;

    public decimal PUnidadMedId { get; set; }

    public string UnidadMedCod { get; set; } = null!;

    public string CategoriaCod { get; set; } = null!;

    public string LineaProdCod { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public decimal PUbicacionId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public decimal PSerieProductoId { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte SituacionContCod { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public double Cantidad { get; set; }

    public double Cantidad2 { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }
}
