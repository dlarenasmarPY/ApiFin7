using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTDoctoInstCredito
{
    public int InstCod { get; set; }

    public short TdoId { get; set; }

    public short Cantidad { get; set; }

    public short DiasVigencia { get; set; }
}
