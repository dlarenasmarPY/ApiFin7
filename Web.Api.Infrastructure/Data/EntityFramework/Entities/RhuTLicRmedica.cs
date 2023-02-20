using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTLicRmedica
{
    public decimal LicRid { get; set; }

    public decimal PLicId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal? PAccId { get; set; }

    public decimal PMedId { get; set; }

    public decimal PTexId { get; set; }

    public string LicRnroLicencia { get; set; } = null!;

    public DateTime LicRfecEmision { get; set; }

    public DateTime LicRfecInicio { get; set; }

    public short LicRdias { get; set; }

    public DateTime LicRfecTermino { get; set; }

    public bool LicRprorroga { get; set; }

    public decimal LicRidProrroga { get; set; }

    public decimal PItmTipLicId { get; set; }

    public decimal? PAntGruFamId { get; set; }

    public DateTime LicRfecNacHijo { get; set; }

    public DateTime LicRfecConcepcion { get; set; }

    public bool LicRindRecupLab { get; set; }

    public bool LicRindTramInv { get; set; }

    public DateTime LicRfecAccidente { get; set; }

    public DateTime LicRhoraAccidente { get; set; }

    public byte LicRtrayAccidente { get; set; }

    public decimal PItmTipRepId { get; set; }

    public decimal PItmTraRepId { get; set; }

    public decimal PItmLugRepId { get; set; }

    public string LicRfono { get; set; } = null!;

    public string LicRdireccion { get; set; } = null!;

    public DateTime LicRfecRegistro { get; set; }

    public DateTime LicRfecDespacho { get; set; }

    public bool LicRindEnviado { get; set; }

    public decimal? PInstTramId { get; set; }

    public DateTime LicRfecRecepcion { get; set; }

    public DateTime LicRfecRechaDis { get; set; }

    public string LicRmotivo { get; set; } = null!;

    public decimal PItmEstLicId { get; set; }

    public short LicRdiasSubsidio { get; set; }

    public double LicRmontoDiasSub { get; set; }

    public double LicRtotalSubsidio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTLicAccidente? PAcc { get; set; }

    public virtual RhuTFicAntGrupoFamiliar? PAntGruFam { get; set; }

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParInstitucione? PInstTram { get; set; }

    public virtual RhuTParItem PItmEstLic { get; set; } = null!;

    public virtual RhuTParItem PItmLugRep { get; set; } = null!;

    public virtual RhuTParItem PItmTipRep { get; set; } = null!;

    public virtual RhuTParItem PItmTraRep { get; set; } = null!;

    public virtual RhuTLicMedico PMed { get; set; } = null!;

    public virtual RhuTExcTipExc PTex { get; set; } = null!;
}
