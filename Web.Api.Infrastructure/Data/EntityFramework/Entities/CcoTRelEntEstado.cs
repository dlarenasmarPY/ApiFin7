using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelEntEstado
{
    public decimal PEntCcoId { get; set; }

    public short EstDocCod { get; set; }

    public string RelEntEst { get; set; } = null!;
}
