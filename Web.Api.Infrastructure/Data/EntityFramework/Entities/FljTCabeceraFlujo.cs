using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class FljTCabeceraFlujo
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public DateTime TesDocFecha { get; set; }

    public short TesTdoId { get; set; }

    public int TesDocNumInterno { get; set; }

    public int TesDocLinea { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public int CreCodigo { get; set; }

    public string TesRut { get; set; } = null!;

    public decimal EntSucId { get; set; }

    public short TesDocTipoDocCalce { get; set; }

    public string TesDocNumDocCalce { get; set; } = null!;

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string MovCceGlosa { get; set; } = null!;

    public decimal TesDocMontoImpuDebe { get; set; }

    public decimal TesDocMontoImpuHaber { get; set; }

    public decimal TesDocMontoLocalDebe { get; set; }

    public decimal TesDocMontoLocalHaber { get; set; }
}
