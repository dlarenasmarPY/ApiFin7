using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienDatSeg
{
    public decimal PCodigoBienId { get; set; }

    public decimal PEntIdSeg { get; set; }

    public DateTime AfiFechaIniCob { get; set; }

    public DateTime AfiFechaFinCob { get; set; }

    public int AfiNumPoliza { get; set; }

    public double AfiMontoAseg { get; set; }

    public decimal PMonedaId { get; set; }

    public byte AfiTipoSegCod { get; set; }

    public double AfiPrimAnual { get; set; }

    public double AfiCuotaPrima { get; set; }

    public decimal PEntIdCorrSeg { get; set; }

    public byte AfiTipoPrendaCod { get; set; }

    public double AfiMontoPrenda { get; set; }

    public decimal PEntIdPren { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
