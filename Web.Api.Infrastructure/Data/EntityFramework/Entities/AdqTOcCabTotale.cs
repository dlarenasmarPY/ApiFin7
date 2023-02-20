using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcCabTotale
{
    public decimal OcCabTotalesId { get; set; }

    public decimal POcCabId { get; set; }

    public double ValorTotal { get; set; }

    public double TotalDesctoItem { get; set; }

    public double ValorTotalDescto { get; set; }

    public double TotalDesctoGral { get; set; }

    public double DesctoProntoPago { get; set; }

    public double TotalFlete { get; set; }

    public double TotalAfeIva { get; set; }

    public double TotalExeIva { get; set; }

    public double Iva { get; set; }

    public double TotalIva { get; set; }

    public double TotalImpuestoAdi { get; set; }

    public double TotalImpuestoOtro { get; set; }

    public double TotalRetencion { get; set; }

    public double TotalOrdenCompra { get; set; }

    public double ValorImptoCombust { get; set; }

    public virtual AdqTOcCab POcCab { get; set; } = null!;
}
