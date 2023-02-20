using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTLcoDoctoLegal
{
    public string CodOwner { get; set; } = null!;

    public decimal CabLlgId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte LlgDocEstado { get; set; }

    public string OpeGlosa { get; set; } = null!;

    public int LlgDocNumInterno { get; set; }

    public string LlgDocNumDoc { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public DateTime LlgDocFechaIng { get; set; }

    public DateTime LlgDocFecha { get; set; }

    public string ConEstGlosa { get; set; } = null!;

    public decimal PEntIdSec { get; set; }

    public decimal PEntIdTer { get; set; }

    public int LlgDocNumProvision { get; set; }

    public string LlgDocDigUsuario { get; set; } = null!;

    public DateTime LlgDocDigFecha { get; set; }

    public string LlgDocAprUsuario { get; set; } = null!;

    public DateTime LlgDocAprFecha { get; set; }

    public string LlgDocActUsuario { get; set; } = null!;

    public DateTime LlgDocActFecha { get; set; }

    public string MonSimbolo { get; set; } = null!;

    public decimal LlgDocMtoImpuTotal { get; set; }
}
