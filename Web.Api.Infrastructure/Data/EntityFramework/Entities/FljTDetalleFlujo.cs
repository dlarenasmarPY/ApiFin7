using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class FljTDetalleFlujo
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

    public decimal PCreId { get; set; }

    public string Rut { get; set; } = null!;

    public short SucNumero { get; set; }

    public short DocTipoDocCalce { get; set; }

    public string DocNumDocCalce { get; set; } = null!;

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public string ChequeGlosa { get; set; } = null!;

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public int EmpIdOrigen { get; set; }

    public short DivCodigoOrigen { get; set; }

    public int DocNumChqInterno { get; set; }

    public byte MonCodigoDoc { get; set; }

    public double MovTesMontoLocalDebe { get; set; }

    public double MovTesMontoLocalHaber { get; set; }

    public int NumCheque { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public byte ChqAsignado { get; set; }

    public int CabOpeLineaCorr { get; set; }
}
