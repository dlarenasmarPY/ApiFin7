using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieBeneficio
{
    public decimal BeneficiosId { get; set; }

    public decimal CodBeneficio { get; set; }

    public decimal TipoBeneficio { get; set; }

    public string DesBeneficio { get; set; } = null!;

    public DateTime FecVigencia { get; set; }

    public DateTime FecExpiracion { get; set; }

    public decimal PBieEleFpago { get; set; }

    public decimal TipoCarencia { get; set; }

    public byte MesPago { get; set; }

    public byte PagoAutomatico { get; set; }

    public string Restriccion { get; set; } = null!;

    public string Alcances { get; set; } = null!;

    public decimal TipoApertura { get; set; }

    public decimal TipoAgrupacion { get; set; }

    public byte BiePeriodicidad { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PPryId { get; set; }

    public short TdoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PBieEleFpagoNavigation { get; set; } = null!;

    public virtual ICollection<RhuTBieApertura> RhuTBieAperturas { get; } = new List<RhuTBieApertura>();

    public virtual ICollection<RhuTBieBeneficiosRemun> RhuTBieBeneficiosRemuns { get; } = new List<RhuTBieBeneficiosRemun>();

    public virtual ICollection<RhuTBieBeneficiosTope> RhuTBieBeneficiosTopes { get; } = new List<RhuTBieBeneficiosTope>();

    public virtual ICollection<RhuTBieSociosTope> RhuTBieSociosTopes { get; } = new List<RhuTBieSociosTope>();

    public virtual ICollection<RhuTBieSolicitude> RhuTBieSolicitudes { get; } = new List<RhuTBieSolicitude>();

    public virtual RhuTParItem TipoAgrupacionNavigation { get; set; } = null!;

    public virtual RhuTParItem TipoAperturaNavigation { get; set; } = null!;

    public virtual RhuTParItem TipoBeneficioNavigation { get; set; } = null!;

    public virtual RhuTParItem TipoCarenciaNavigation { get; set; } = null!;
}
