using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemConceptosCont
{
    public decimal ContConcId { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PItmGruConId { get; set; }

    public decimal PPerRemIdIni { get; set; }

    public decimal PPerRemIdTer { get; set; }

    public string TipoImputacion { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PItmTipEntOri { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PCfiId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public short TdoId { get; set; }

    public decimal PConceptoCcpId { get; set; }

    public decimal PEntIdTer { get; set; }

    public decimal PCtaIdAporte { get; set; }

    public decimal PItmTipEntOriAporte { get; set; }

    public decimal PCdiIdAporte { get; set; }

    public decimal PTprIdAporte { get; set; }

    public decimal PCfiIdAporte { get; set; }

    public string PryNumeroAporte { get; set; } = null!;

    public decimal PLineaProdIdAporte { get; set; }

    public short TdoIdAporte { get; set; }

    public decimal PConceptoCcpIdAporte { get; set; }

    public decimal PEntIdTerAporte { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;
}
