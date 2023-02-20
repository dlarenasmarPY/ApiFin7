using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDetSerieLote
{
    public decimal OpeLogtDetSerLotId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal PSerieProductoId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public decimal PDocReferenciaId { get; set; }

    public decimal PUbicacionId { get; set; }

    public double CantEntrada { get; set; }

    public double CantSalida { get; set; }

    public double CantEntrada2 { get; set; }

    public double CantSalida2 { get; set; }

    public decimal PUnidadMedOrigenId { get; set; }

    public double ValorUniOpeMonedaOrigen { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorUniOpeMonedaAlt { get; set; }

    public double ValorOpeMoneda { get; set; }

    public double ValorOpeMonedaAlt { get; set; }

    public double CantBodegaOrigen { get; set; }

    public double Cantidad { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double Cantidad2 { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public decimal PSaldoCierreLoteId { get; set; }

    public double ValorUniOpeMonedaCorregido { get; set; }

    public double ValorOpeMonedaCorregido { get; set; }

    public double CostoPromMonedaCorregido { get; set; }

    public double CostoMonedaCorregido { get; set; }

    public virtual LogTOperacionesLogtDet POpeLogtDet { get; set; } = null!;
}
