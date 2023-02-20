using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTIdiomaEspTecnica
{
    public decimal IdiomaEspId { get; set; }

    public string IdiomaEspDes { get; set; } = null!;

    public virtual ICollection<ExiTProductosEspTecCab> ExiTProductosEspTecCabs { get; } = new List<ExiTProductosEspTecCab>();
}
