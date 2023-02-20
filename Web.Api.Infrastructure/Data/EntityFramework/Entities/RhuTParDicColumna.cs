using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParDicColumna
{
    public decimal DicId { get; set; }

    public decimal PDitId { get; set; }

    public string DicNombreFisico { get; set; } = null!;

    public string DicNombreLogico { get; set; } = null!;

    public short DicLargo { get; set; }

    public string DicColumna { get; set; } = null!;

    public byte DicIndAnexo { get; set; }

    public string DicAnxNombreFisico { get; set; } = null!;

    public byte DicIndAuditoria { get; set; }

    public byte DicNumOrder { get; set; }

    public virtual RhuTParDicTabla PDit { get; set; } = null!;

    public virtual ICollection<RhuTParInterfazDet> RhuTParInterfazDets { get; } = new List<RhuTParInterfazDet>();
}
