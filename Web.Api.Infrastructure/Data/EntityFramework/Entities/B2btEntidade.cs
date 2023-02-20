using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class B2btEntidade
{
    public decimal PEntId { get; set; }

    public string B2bpassword { get; set; } = null!;

    public DateTime B2bfechaUltConsulta { get; set; }
}
