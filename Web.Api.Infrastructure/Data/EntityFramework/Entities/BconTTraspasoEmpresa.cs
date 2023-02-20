using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class BconTTraspasoEmpresa
{
    public decimal PEmpId { get; set; }

    public int EmpIdDest { get; set; }

    public byte FldTipoCalculo { get; set; }

    public decimal EmpIdAfi { get; set; }
}
