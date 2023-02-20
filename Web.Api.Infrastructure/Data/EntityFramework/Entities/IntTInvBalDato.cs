using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInvBalDato
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short EjeAno { get; set; }

    public short PerId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public string IntTmpArchivo { get; set; } = null!;

    public int CtaCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public int DetDesLinea { get; set; }

    public string DetDesCodigo { get; set; } = null!;

    public string DetDesDescripcion { get; set; } = null!;

    public DateTime DetDesCalFecha { get; set; }

    public short TdoId { get; set; }

    public string DetDesNumero { get; set; } = null!;

    public short DetDesNumCuota { get; set; }

    public DateTime DetDesFecVenc { get; set; }

    public double DetDesMontoImpuDebe { get; set; }

    public double DetDesMontoImpuHaber { get; set; }

    public double DetDesMontoLocalDebe { get; set; }

    public double DetDesMontoLocalHaber { get; set; }

    public string DetDesGlosa { get; set; } = null!;
}
