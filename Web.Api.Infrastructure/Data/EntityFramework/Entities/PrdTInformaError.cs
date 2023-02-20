using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTInformaError
{
    public decimal PFormulaId { get; set; }

    public string CodigoError { get; set; } = null!;

    public string DescripcionError { get; set; } = null!;
}
