using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTCriticidad
{
    public byte CriCcoCod { get; set; }

    public string CriCcoGlosa { get; set; } = null!;
}
