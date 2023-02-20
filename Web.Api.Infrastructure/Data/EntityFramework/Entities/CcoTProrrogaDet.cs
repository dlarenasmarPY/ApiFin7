using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTProrrogaDet
{
    public decimal DetProrrogaId { get; set; }

    public decimal PProrrogaId { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public double ProDetMontoDocumento { get; set; }

    public double ProrrogaTasa { get; set; }

    public double ProDetMontoInteres { get; set; }

    public DateTime DocCceFecVenc { get; set; }

    public DateTime DocCceFecProrroga { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
