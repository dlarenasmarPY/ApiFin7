using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTPeriodoCol
{
    public int Perid { get; set; }

    public string PerGlosa { get; set; } = null!;

    public int EjeAno { get; set; }

    public int Col { get; set; }
}
