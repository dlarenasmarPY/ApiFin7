using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelConfiguracion
{
    public decimal IdSelConfiguracion { get; set; }

    public short SelConDiasMaxDot { get; set; }

    public short SelConMaxRegistros { get; set; }

    public short SelConMotivoDot { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }
}
