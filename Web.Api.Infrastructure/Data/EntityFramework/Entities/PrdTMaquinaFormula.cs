using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTMaquinaFormula
{
    public decimal MaquinaFormulaId { get; set; }

    public decimal PMaquinaId { get; set; }

    public decimal PFormulaId { get; set; }

    public decimal PProductoId { get; set; }

    public int MaquinaSetup { get; set; }

    public decimal MaquinaVel { get; set; }
}
