using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTAsociaNominaDocumento
{
    public decimal PEmpId { get; set; }

    public byte TipNomCod { get; set; }

    public short TdoId { get; set; }

    public byte IndAcumulaMonto { get; set; }

    public byte IndEmisionDocumento { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCtaIdIntPorDevengar { get; set; }

    public decimal PCtaIdIntDevengado { get; set; }

    public short CcoNumDias { get; set; }

    public short CcoNumCuotas { get; set; }

    public short CcoFormatoCod { get; set; }
}
