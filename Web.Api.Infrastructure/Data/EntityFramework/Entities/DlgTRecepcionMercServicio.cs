using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTRecepcionMercServicio
{
    public decimal RecepcionMercServicioId { get; set; }

    public decimal PEmpId { get; set; }

    public string RecMerRutEmisor { get; set; } = null!;

    public string RecMerXml { get; set; } = null!;

    public DateTime RecMerFecFirma { get; set; }

    public decimal PEntIdFirma { get; set; }

    public DateTime RecMerFecEnvia { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PEntSucId { get; set; }
}
