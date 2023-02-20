using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpdet
{
    public decimal OpdetId { get; set; }

    public decimal POpcabId { get; set; }

    public int Item { get; set; }

    public int Linea { get; set; }

    public decimal PFormulaId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PUnidadMedIdFormula { get; set; }

    public short TipoDestinoOp { get; set; }

    public double CantDocOrigen { get; set; }

    public double CantidadProduccion { get; set; }

    public decimal PUnidadMedIdProduccion { get; set; }

    public double CantidadStock { get; set; }

    public double CantPendiente { get; set; }

    public decimal PBodegaId { get; set; }

    public DateTime FechaEntrega { get; set; }

    public decimal PDocOrigenDetId { get; set; }

    public decimal POpdestinoId { get; set; }

    public decimal POpmadreId { get; set; }

    public double CostoEstandar { get; set; }

    public double CostoEstandarTrib { get; set; }

    public double CostoEstandarSinCorr { get; set; }

    public double CostoEstandarTotal { get; set; }

    public double CostoEstandarTribTotal { get; set; }

    public double CostoEstandarSinCorrTotal { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorOpeMoneda { get; set; }

    public double ValorUniOpeMonedaCorregido { get; set; }

    public double ValorOpeMonedaCorregido { get; set; }

    public double ValorUniOpeMonedaSinCorr { get; set; }

    public double ValorOpeMonedaSinCorr { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PPedidoMaterialId { get; set; }

    public decimal PPuertoId { get; set; }

    public decimal PEntId { get; set; }

    public double ValorUniOpeMonedaAlt { get; set; }

    public double ValorOpeMonedaAlt { get; set; }

    public byte Revalorizado { get; set; }
}
