using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTablaDatosAfi
{
    public short BitFicLinea { get; set; }

    public string BitFicArchivo { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal CtoNumero { get; set; }

    public string TabCodigo { get; set; } = null!;

    public short ItmCodigo { get; set; }

    public DateTime AfiCtoFecVigDesde { get; set; }

    public string FldUserCode { get; set; } = null!;

    public string IdFuncionUlt { get; set; } = null!;
}
