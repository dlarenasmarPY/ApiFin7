using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTFormulario
{
    public short CodFormulario { get; set; }

    public string DesFormulario { get; set; } = null!;

    public byte IndFormulario { get; set; }
}
