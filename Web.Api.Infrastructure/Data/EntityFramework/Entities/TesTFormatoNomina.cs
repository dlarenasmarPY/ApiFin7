using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTFormatoNomina
{
    public int FormNomCod { get; set; }

    public string FormNomDes { get; set; } = null!;

    public int InstCod { get; set; }
}
