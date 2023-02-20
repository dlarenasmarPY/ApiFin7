using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTPlanillasLproducto
{
    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CfgNumId { get; set; }

    public string FldUserCode { get; set; } = null!;

    public int CreCodigo { get; set; }

    public int CtaCodigo { get; set; }

    public short LineaProId { get; set; }

    public decimal PorcVenta { get; set; }

    public decimal PorcCosto { get; set; }

    public decimal PorcMargen { get; set; }
}
