using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuConceptosCont
{
    public decimal TmpConcCon { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PConcRemId { get; set; }

    public decimal PItmGruConId { get; set; }

    public string TipoImputacion { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal TipoOrigen { get; set; }

    public byte TauId { get; set; }

    public byte CtaUsaCentroResp { get; set; }

    public byte CtaUsaConcepto { get; set; }

    public byte CtaUsaProyecto { get; set; }

    public byte CtaMultiMoneda { get; set; }

    public byte CtaUsaRut { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PCfiId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public short TdoId { get; set; }

    public string Rut { get; set; } = null!;

    public decimal PConceptoCcpId { get; set; }

    public int CreCodigo { get; set; }

    public decimal PEntIdTer { get; set; }

    public decimal PCtaIdAporte { get; set; }

    public decimal TipoOrigenAporte { get; set; }

    public byte XTauId { get; set; }

    public byte XCtaUsaCentroResp { get; set; }

    public byte XCtaUsaConcepto { get; set; }

    public byte XCtaUsaProyecto { get; set; }

    public bool XCtaMultiMoneda { get; set; }

    public byte XCtaUsaRut { get; set; }

    public decimal PCdiIdAporte { get; set; }

    public decimal PTprIdAporte { get; set; }

    public decimal PCfiIdAporte { get; set; }

    public string PryNumeroAporte { get; set; } = null!;

    public decimal PLineaProdIdAporte { get; set; }

    public short TdoIdAporte { get; set; }

    public string XRut { get; set; } = null!;

    public int XCreCodigo { get; set; }

    public string TbMnombre { get; set; } = null!;

    public string AtrMnombre { get; set; } = null!;

    public string CnRtipoVariable { get; set; } = null!;

    public decimal PConceptoCcpIdAporte { get; set; }

    public decimal PEntIdTerAporte { get; set; }
}
