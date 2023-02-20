using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTInventarioDet
{
    public decimal InvDetId { get; set; }

    public decimal PInvCabId { get; set; }

    public int Linea { get; set; }

    public DateTime FechaRecuento { get; set; }

    public string RespRecuento { get; set; } = null!;

    public DateTime FechaConfirmacion { get; set; }

    public string RespConfirmacion { get; set; } = null!;

    public decimal PProductoId { get; set; }

    public decimal PUbicacionId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public decimal PSerieProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public double CantRecuento { get; set; }

    public double CantConfirmacion { get; set; }

    public double Cantidad { get; set; }

    public decimal PUnidadMedId { get; set; }

    public double CantRecuento2 { get; set; }

    public double CantConfirmacion2 { get; set; }

    public double Cantidad2 { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public byte IndHojaInv { get; set; }

    public int HojaInv { get; set; }

    public int InvNroRecuento { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
