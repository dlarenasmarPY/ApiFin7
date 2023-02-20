using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTTransformacionDet
{
    public decimal TranDetId { get; set; }

    public decimal PTranCabId { get; set; }

    public decimal PPedidoMaterialDetId { get; set; }

    public decimal PReservasDetId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PProductoCodId { get; set; }

    public byte IndFabricacion { get; set; }

    public double Cantidad { get; set; }

    public decimal PUnidadMedId { get; set; }

    public double Cantidad2 { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorUniOpeMonedaAlt { get; set; }

    public double ValorOpeMoneda { get; set; }

    public double ValorOpeMonedaAlt { get; set; }

    public double IncidenciaPorc { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public string GlosaExis { get; set; } = null!;

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioConfirma { get; set; } = null!;

    public DateTime FechaConfirma { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
