using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueDoctosAge
{
    public decimal EmbarqueDocAgeId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public int EmbNumeroGuia { get; set; }

    public int EmbNumeroDespacho { get; set; }

    public double EmbGastosDespacho { get; set; }

    public string EmbManifiesto { get; set; } = null!;

    public DateTime EmbFechaManifiesto { get; set; }

    public double EmbMontoRemesa { get; set; }

    public double EmbPagoDerechos { get; set; }

    public int EmbTasaAeronautica { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
