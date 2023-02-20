using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParDicTabla
{
    public decimal DitId { get; set; }

    public int DitSecuencia { get; set; }

    public string DitNombreFisico { get; set; } = null!;

    public string DitNombreLogico { get; set; } = null!;

    public byte DitFuncion { get; set; }

    public virtual ICollection<RhuTParDicColumna> RhuTParDicColumnas { get; } = new List<RhuTParDicColumna>();
}
