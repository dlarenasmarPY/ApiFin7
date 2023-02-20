using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelEntDocumento
{
    public decimal PEntCcoId { get; set; }

    public short TdoId { get; set; }

    public string RelEntDoc { get; set; } = null!;
}
