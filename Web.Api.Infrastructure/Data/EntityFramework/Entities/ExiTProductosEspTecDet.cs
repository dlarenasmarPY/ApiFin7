using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosEspTecDet
{
    public decimal ProductoEspTecDetId { get; set; }

    public decimal PProductoEspTecId { get; set; }

    public int Linea { get; set; }

    public string DescripcionTec { get; set; } = null!;

    public double Cantidad { get; set; }

    public decimal PUnidadMedId { get; set; }

    public virtual ExiTProductosEspTecCab PProductoEspTec { get; set; } = null!;
}
