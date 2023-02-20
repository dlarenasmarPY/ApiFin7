using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTablaDatosRen
{
    public short BitFicLinea { get; set; }

    public string BitFicArchivo { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal CtoNumero { get; set; }

    public string CnRcodigo { get; set; } = null!;

    public DateTime RtaFecVigDesde { get; set; }

    public DateTime RtaFecVigHasta { get; set; }

    public decimal RtaValNumerico { get; set; }

    public decimal RtaValBaseNum { get; set; }

    public string FldUserCode { get; set; } = null!;

    public string IdFuncionUlt { get; set; } = null!;
}
