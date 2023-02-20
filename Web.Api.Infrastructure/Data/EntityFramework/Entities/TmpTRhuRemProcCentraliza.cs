using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemProcCentraliza
{
    public string CodOwner { get; set; } = null!;

    public decimal PItmGruConId { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PLiqTotId { get; set; }

    public decimal PliqDetId { get; set; }

    public decimal PConcRemId { get; set; }

    public string TipoImputacion { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PEntId { get; set; }

    public string EntRut { get; set; } = null!;

    public decimal TipoOrigen { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PCfiId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public short TdoId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCtaIdAporte { get; set; }

    public decimal EntId2 { get; set; }

    public string Rut { get; set; } = null!;

    public decimal TipoOrigenAporte { get; set; }

    public decimal PCdiIdAporte { get; set; }

    public decimal PTprIdAporte { get; set; }

    public decimal PCfiIdAporte { get; set; }

    public string PryNumeroAporte { get; set; } = null!;

    public decimal PLineaProdIdAporte { get; set; }

    public short TdoIdAporte { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PMovCceId { get; set; }

    public decimal PMovCceIdAp { get; set; }

    public decimal PCtoId { get; set; }

    public string GlosaErrorValida { get; set; } = null!;
}
