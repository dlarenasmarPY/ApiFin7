using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VenTDoctoLegalDet
{
    public decimal DoctoLegalDetId { get; set; }

    public decimal PDoctoLegalCarId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public double DldCantDoctoFac { get; set; }

    public double DvdPrecioUnitario { get; set; }

    public double DvdDescto1 { get; set; }

    public double DvdDescto2 { get; set; }

    public double DvdDescto3 { get; set; }

    public double DvdDescto4 { get; set; }

    public byte LprMoneda { get; set; }

    public double MonVdmValor1 { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public byte IndicaSerie { get; set; }

    public byte IndicaLote { get; set; }

    public string DvdAfectoExento { get; set; } = null!;

    public string TipoCodigo { get; set; } = null!;

    public short DldNota { get; set; }
}
