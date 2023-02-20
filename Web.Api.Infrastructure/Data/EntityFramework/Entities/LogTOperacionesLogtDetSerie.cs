using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDetSerie
{
    public decimal OpeLogtDetSerId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal POpeLogtDetserlotId { get; set; }

    public decimal PSerieProductoId { get; set; }

    public decimal PDocReferenciaId { get; set; }

    public decimal PUbicacionId { get; set; }

    public double CantEntrada { get; set; }

    public double CantSalida { get; set; }

    public double CantEntrada2 { get; set; }

    public double CantSalida2 { get; set; }

    public decimal PUnidadMedOrigenId { get; set; }

    public double CantBodegaOrigen { get; set; }

    public double Cantidad { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public double Cantidad2 { get; set; }

    public decimal PUnidadMed2Id { get; set; }
}
