using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicPersona
{
    public decimal FicPerId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PEntDirId { get; set; }

    public string FicIdent1 { get; set; } = null!;

    public string FicIdent2 { get; set; } = null!;

    public string FicIdent3 { get; set; } = null!;

    public decimal PItmSexoId { get; set; }

    public decimal PItmEstCivilId { get; set; }

    public string FiceMail { get; set; } = null!;

    public decimal PItmProfesionId { get; set; }

    public DateTime FicFecNacimiento { get; set; }

    public decimal PItmNacionalidadId { get; set; }

    public decimal FicCmuCodigo { get; set; }

    public decimal PItmNivLabId { get; set; }

    public string FicCelular { get; set; } = null!;

    public decimal PItmOrigenCurId { get; set; }

    public decimal PItmDisponId { get; set; }

    public byte FicIndRecomendado { get; set; }

    public string FicEntRazonSocial { get; set; } = null!;

    public decimal PItmFicEstadoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual RhuTParItem PItmEstCivil { get; set; } = null!;

    public virtual RhuTParItem PItmFicEstado { get; set; } = null!;

    public virtual RhuTParItem PItmNacionalidad { get; set; } = null!;

    public virtual RhuTParItem PItmSexo { get; set; } = null!;

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratos { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambios { get; } = new List<RhuTCtoSolCambio>();

    public virtual RhuTEvaEvaluador? RhuTEvaEvaluador { get; set; }

    public virtual ICollection<RhuTFicAntAcademico> RhuTFicAntAcademicos { get; } = new List<RhuTFicAntAcademico>();

    public virtual ICollection<RhuTFicAntActExtra> RhuTFicAntActExtras { get; } = new List<RhuTFicAntActExtra>();

    public virtual ICollection<RhuTFicAntAfp> RhuTFicAntAfps { get; } = new List<RhuTFicAntAfp>();

    public virtual ICollection<RhuTFicAntApv> RhuTFicAntApvs { get; } = new List<RhuTFicAntApv>();

    public virtual ICollection<RhuTFicAntComplementario> RhuTFicAntComplementarios { get; } = new List<RhuTFicAntComplementario>();

    public virtual RhuTFicAntEmergencium? RhuTFicAntEmergencium { get; set; }

    public virtual ICollection<RhuTFicAntGrupoFamiliar> RhuTFicAntGrupoFamiliars { get; } = new List<RhuTFicAntGrupoFamiliar>();

    public virtual ICollection<RhuTFicAntIdioma> RhuTFicAntIdiomas { get; } = new List<RhuTFicAntIdioma>();

    public virtual ICollection<RhuTFicAntImponible> RhuTFicAntImponibles { get; } = new List<RhuTFicAntImponible>();

    public virtual ICollection<RhuTFicAntLaborale> RhuTFicAntLaborales { get; } = new List<RhuTFicAntLaborale>();

    public virtual ICollection<RhuTFicAntMedico> RhuTFicAntMedicos { get; } = new List<RhuTFicAntMedico>();

    public virtual ICollection<RhuTFicAntPrevisionale> RhuTFicAntPrevisionales { get; } = new List<RhuTFicAntPrevisionale>();

    public virtual ICollection<RhuTFicAntSalud> RhuTFicAntSaluds { get; } = new List<RhuTFicAntSalud>();

    public virtual ICollection<RhuTFicCertificacione> RhuTFicCertificaciones { get; } = new List<RhuTFicCertificacione>();

    public virtual ICollection<RhuTFicDctosFi> RhuTFicDctosFis { get; } = new List<RhuTFicDctosFi>();

    public virtual ICollection<RhuTLicAccidente> RhuTLicAccidentes { get; } = new List<RhuTLicAccidente>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicas { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicas { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTPerSolicitud> RhuTPerSolicituds { get; } = new List<RhuTPerSolicitud>();

    public virtual ICollection<RhuTPerVacGanada> RhuTPerVacGanada { get; } = new List<RhuTPerVacGanada>();

    public virtual ICollection<RhuTRemLiqTotalesPer> RhuTRemLiqTotalesPers { get; } = new List<RhuTRemLiqTotalesPer>();

    public virtual ICollection<RhuTSelPostulante> RhuTSelPostulantes { get; } = new List<RhuTSelPostulante>();

    public virtual ICollection<RhuTSelSolicitud> RhuTSelSolicitudPFicPerCoords { get; } = new List<RhuTSelSolicitud>();

    public virtual ICollection<RhuTSelSolicitud> RhuTSelSolicitudPFicPerSolics { get; } = new List<RhuTSelSolicitud>();
}
