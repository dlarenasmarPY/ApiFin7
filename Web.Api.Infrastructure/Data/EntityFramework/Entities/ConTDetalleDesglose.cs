using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTDetalleDesglose
{
    public decimal DetDesId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public short EjeAno { get; set; }

    public decimal PCtaId { get; set; }

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

    public string DetDesDigUsuario { get; set; } = null!;

    public DateTime DetDesDigFec { get; set; }

    public string DetDesActUsuario { get; set; } = null!;

    public DateTime DetDesActFec { get; set; }

    public string DetDesArchivo { get; set; } = null!;
}
