using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CbaTCartolasTmp
{
    public string CarTmpOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string CarTmpArchivo { get; set; } = null!;

    public decimal PCtaCteBcoId { get; set; }

    public int CarTmpFolio { get; set; }

    public DateTime CarTmpFechaInicio { get; set; }

    public DateTime CarTmpFechaTermino { get; set; }

    public double CarTmpSaldoInicial { get; set; }

    public double CarTmpSaldoFinal { get; set; }

    public decimal PCtbId { get; set; }

    public DateTime CarDetTmpFecha { get; set; }

    public int CarDetTmpNumeroDoc { get; set; }

    public double CarDetTmpMonto { get; set; }

    public int CarDetTmpLinea { get; set; }
}
