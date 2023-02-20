using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTComprobante
{
    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CfgNumId { get; set; }

    public short PerId { get; set; }

    public int ComNumero { get; set; }

    public string EmpRut { get; set; } = null!;

    public string ComGlosa { get; set; } = null!;

    public int ClaCreNodoCodigoAlt { get; set; }

    public string ComOwner { get; set; } = null!;

    public DateTime ComFecDig { get; set; }
}
