using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcCabComercial
{
    public decimal OcCabComerId { get; set; }

    public decimal POcCabId { get; set; }

    public decimal PCondPagoId { get; set; }

    public decimal PMonedaId { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public short PlazoPrePago { get; set; }

    public double DesctoPorcPrepago { get; set; }

    public byte IndModificaPrecio { get; set; }

    public decimal PClausulaId { get; set; }

    public double ClausulaPorcFob { get; set; }

    public double ClausulaPorcCif { get; set; }

    public double ClausulaPorcBodega { get; set; }

    public virtual GlbTMoneda PMoneda { get; set; } = null!;

    public virtual AdqTOcCab POcCab { get; set; } = null!;
}
