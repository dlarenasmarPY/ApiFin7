using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelDocumento
{
    public decimal PEmpId { get; set; }

    public decimal PEntCcoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public string DocCceNumDocBanco { get; set; } = null!;
}
