using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTCmfinanciera
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short EjeAno { get; set; }

    public short PerId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PBodegaId { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte SituacionContCod { get; set; }

    public decimal PLoteProductoId { get; set; }

    public decimal PSerieProductoId { get; set; }

    public byte IndProvisorioCm { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double Cantidad { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public decimal PIndCmid { get; set; }

    public DateTime FechaUltCompra { get; set; }

    public decimal PMonedaUltCompraId { get; set; }

    public double IpcFactorFinanciera { get; set; }

    public double CostoPromMonedaCm { get; set; }

    public double CostoPromMonedaAltCm { get; set; }

    public double CostoMonedaCm { get; set; }

    public double CostoMonedaAltCm { get; set; }

    public double DiferenciaCostoTotalMoneda { get; set; }

    public double DiferenciaCostoTotalMonedaAlt { get; set; }

    public string LogOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
