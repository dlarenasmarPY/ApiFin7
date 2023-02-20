using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTLicMedica
{
    public decimal LicId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal? PAccId { get; set; }

    public decimal PMedId { get; set; }

    public decimal PTexId { get; set; }

    public string LicNroLicencia { get; set; } = null!;

    public DateTime LicFecEmision { get; set; }

    public DateTime LicFecInicio { get; set; }

    public short LicDias { get; set; }

    public DateTime LicFecTermino { get; set; }

    public bool LicProrroga { get; set; }

    public decimal LicIdProrroga { get; set; }

    public decimal PItmTipLicId { get; set; }

    public decimal? PAntGruFamId { get; set; }

    public DateTime LicFecNacHijo { get; set; }

    public DateTime LicFecConcepcion { get; set; }

    public bool LicIndRecupLab { get; set; }

    public bool LicIndTramInv { get; set; }

    public DateTime LicFecAccidente { get; set; }

    public DateTime LicHoraAccidente { get; set; }

    public byte LicTrayAccidente { get; set; }

    public decimal PItmTipRepId { get; set; }

    public decimal PItmTraRepId { get; set; }

    public decimal PItmLugRepId { get; set; }

    public string LicFono { get; set; } = null!;

    public string LicDireccion { get; set; } = null!;

    public DateTime LicFecRegistro { get; set; }

    public DateTime LicFecDespacho { get; set; }

    public bool LicIndEnviado { get; set; }

    public decimal? PInstTramId { get; set; }

    public DateTime LicFecRecepcion { get; set; }

    public DateTime LicFecRechaDis { get; set; }

    public string LicMotivo { get; set; } = null!;

    public decimal PItmEstLicId { get; set; }

    public short LicDiasSubsidio { get; set; }

    public double LicMontoDiasSub { get; set; }

    public double LicTotalSubsidio { get; set; }

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

    public virtual RhuTParItem PItmTipLic { get; set; } = null!;

    public virtual RhuTParItem PItmTipRep { get; set; } = null!;

    public virtual RhuTParItem PItmTraRep { get; set; } = null!;

    public virtual RhuTLicMedico PMed { get; set; } = null!;

    public virtual RhuTExcTipExc PTex { get; set; } = null!;

    public virtual ICollection<RhuTLicDetSubsidio> RhuTLicDetSubsidios { get; } = new List<RhuTLicDetSubsidio>();
}
