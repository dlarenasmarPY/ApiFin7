using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTipoDocumento
{
    public decimal PEmpId { get; set; }

    public short TdoId { get; set; }

    public decimal CtaIdDebe { get; set; }

    public decimal CtaIdHaber { get; set; }

    public decimal CtaIdGastosDebe { get; set; }

    public decimal CtaIdIva { get; set; }

    public byte Emitida { get; set; }

    public decimal CtaIdInteres { get; set; }

    public decimal CtaIdGastosHaber { get; set; }

    public byte TmatModulo { get; set; }
}
