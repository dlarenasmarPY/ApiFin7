using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelEntInstruccion
{
    public decimal PEntCcoId { get; set; }

    public byte InsCcoCod { get; set; }

    public string RelEntIns { get; set; } = null!;
}
