using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfGasto
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PCreId { get; set; }

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public string EntRut { get; set; } = null!;

    public decimal PCtoId { get; set; }

    public decimal CtoNumero { get; set; }

    public string EntRazonSocial { get; set; } = null!;

    public decimal PLugId { get; set; }

    public short LugCodigo { get; set; }

    public string LugDescripcion { get; set; } = null!;

    public decimal PItmGruConId { get; set; }

    public double GccColumna1 { get; set; }

    public double GccColumna2 { get; set; }

    public double GccColumna3 { get; set; }

    public double GccColumna4 { get; set; }

    public double GccColumna5 { get; set; }

    public double GccColumna6 { get; set; }

    public double GccColumna7 { get; set; }

    public double GccColumna8 { get; set; }

    public double GccColumna9 { get; set; }

    public double GccColumna10 { get; set; }
}
