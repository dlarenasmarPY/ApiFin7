using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgtRecepcionBitDetSii
{
    public decimal PRecepcionBitId { get; set; }

    public int Linea { get; set; }

    public string RutEmisorSii { get; set; } = null!;

    public string RazonSocialSii { get; set; } = null!;

    public string TipoDteSii { get; set; } = null!;

    public int FolioDteSii { get; set; }

    public DateTime FechaEmiSii { get; set; }

    public double MontoTotalSii { get; set; }

    public DateTime FechaRecepcionSii { get; set; }

    public string TrackId { get; set; } = null!;
}
