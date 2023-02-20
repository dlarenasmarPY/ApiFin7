using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTConfigProcesosSii
{
    public decimal PEmpId { get; set; }

    public short RangoEnvioMail { get; set; }

    public short RangoOficialSii { get; set; }

    public string WebServiceTesting { get; set; } = null!;

    public string WebServiceProduccion { get; set; } = null!;

    public byte WebServiceEnUso { get; set; }

    public string MailEnviosDteRec { get; set; } = null!;

    public string MailEnviosDteVta { get; set; } = null!;

    public byte IndReclamoAutomatico { get; set; }

    public byte IndUsaCodOc { get; set; }

    public byte TipoProcesoDte { get; set; }
}
