using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParItem
{
    public decimal ItmParId { get; set; }

    public decimal PTabParId { get; set; }

    public short ItmCodigo { get; set; }

    public string ItmDescripcion { get; set; } = null!;

    public string ItmCodigoStr { get; set; } = null!;

    public string ItmCodHomologacion { get; set; } = null!;

    public byte ItmIndUso { get; set; }

    public string ItmEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParTabla PTabPar { get; set; } = null!;

    public virtual ICollection<RhuTApvcAfiliado> RhuTApvcAfiliadoApvcAfRegTributarioNavigations { get; } = new List<RhuTApvcAfiliado>();

    public virtual ICollection<RhuTApvcAfiliado> RhuTApvcAfiliadoPItmFpagoAfs { get; } = new List<RhuTApvcAfiliado>();

    public virtual ICollection<RhuTApvcEmpresa> RhuTApvcEmpresas { get; } = new List<RhuTApvcEmpresa>();

    public virtual ICollection<RhuTBieBeneficio> RhuTBieBeneficioPBieEleFpagoNavigations { get; } = new List<RhuTBieBeneficio>();

    public virtual ICollection<RhuTBieBeneficio> RhuTBieBeneficioTipoAgrupacionNavigations { get; } = new List<RhuTBieBeneficio>();

    public virtual ICollection<RhuTBieBeneficio> RhuTBieBeneficioTipoAperturaNavigations { get; } = new List<RhuTBieBeneficio>();

    public virtual ICollection<RhuTBieBeneficio> RhuTBieBeneficioTipoBeneficioNavigations { get; } = new List<RhuTBieBeneficio>();

    public virtual ICollection<RhuTBieBeneficio> RhuTBieBeneficioTipoCarenciaNavigations { get; } = new List<RhuTBieBeneficio>();

    public virtual ICollection<RhuTBieBeneficiosTope> RhuTBieBeneficiosTopes { get; } = new List<RhuTBieBeneficiosTope>();

    public virtual ICollection<RhuTBieSolicitude> RhuTBieSolicitudePBieEleFpagoNavigations { get; } = new List<RhuTBieSolicitude>();

    public virtual ICollection<RhuTBieSolicitude> RhuTBieSolicitudePBieEles { get; } = new List<RhuTBieSolicitude>();

    public virtual ICollection<RhuTBieSolicitude> RhuTBieSolicitudeTipoBeneficioNavigations { get; } = new List<RhuTBieSolicitude>();

    public virtual ICollection<RhuTCapEjeSence> RhuTCapEjeSences { get; } = new List<RhuTCapEjeSence>();

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucionCapEjeItmEsts { get; } = new List<RhuTCapEjecucion>();

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucionCapEjeItmTipDocNavigations { get; } = new List<RhuTCapEjecucion>();

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucionCapEjeItmVals { get; } = new List<RhuTCapEjecucion>();

    public virtual ICollection<RhuTCapPlane> RhuTCapPlanes { get; } = new List<RhuTCapPlane>();

    public virtual ICollection<RhuTCapPostulantesDet> RhuTCapPostulantesDets { get; } = new List<RhuTCapPostulantesDet>();

    public virtual ICollection<RhuTCtoAfiliacione> RhuTCtoAfiliaciones { get; } = new List<RhuTCtoAfiliacione>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmCalJurAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmCategoriaAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmIntegroAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmJornadaAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmLugarPagoAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmTpContratoAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmTpImptoAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratoPItmTpRtaAnxes { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmCalJurs { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmCategoria { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmIntegros { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmJornada { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmLugarPagos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmTpContratos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmTpImptos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratoPItmTpRta { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoNominasCfdet> RhuTCtoNominasCfdetPItmNomGfaEstadoNavigations { get; } = new List<RhuTCtoNominasCfdet>();

    public virtual ICollection<RhuTCtoNominasCfdet> RhuTCtoNominasCfdetPItmParentescos { get; } = new List<RhuTCtoNominasCfdet>();

    public virtual ICollection<RhuTCtoNominasCfdet> RhuTCtoNominasCfdetPItmSexos { get; } = new List<RhuTCtoNominasCfdet>();

    public virtual ICollection<RhuTCtoNominasCfdet> RhuTCtoNominasCfdetPItmTipCargas { get; } = new List<RhuTCtoNominasCfdet>();

    public virtual ICollection<RhuTCtoNominasCf> RhuTCtoNominasCfs { get; } = new List<RhuTCtoNominasCf>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmCalJurs { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmCategoria { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmIntegros { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmJornada { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmLugarPagos { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmTpContratos { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmTpImptos { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambioPItmTpRta { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolicitude> RhuTCtoSolicitudePItmCtoSolEsts { get; } = new List<RhuTCtoSolicitude>();

    public virtual ICollection<RhuTCtoSolicitude> RhuTCtoSolicitudePItmPars { get; } = new List<RhuTCtoSolicitude>();

    public virtual ICollection<RhuTEpeSolPersonal> RhuTEpeSolPersonals { get; } = new List<RhuTEpeSolPersonal>();

    public virtual ICollection<RhuTEpeSolicitude> RhuTEpeSolicitudePItmParEsts { get; } = new List<RhuTEpeSolicitude>();

    public virtual ICollection<RhuTEpeSolicitude> RhuTEpeSolicitudePItmPars { get; } = new List<RhuTEpeSolicitude>();

    public virtual ICollection<RhuTExcEmpresa> RhuTExcEmpresas { get; } = new List<RhuTExcEmpresa>();

    public virtual ICollection<RhuTExcFechasEve> RhuTExcFechasEves { get; } = new List<RhuTExcFechasEve>();

    public virtual ICollection<RhuTExcPago> RhuTExcPagos { get; } = new List<RhuTExcPago>();

    public virtual ICollection<RhuTExcTipExc> RhuTExcTipExcs { get; } = new List<RhuTExcTipExc>();

    public virtual ICollection<RhuTFicAntAcademico> RhuTFicAntAcademicoPItmCarreras { get; } = new List<RhuTFicAntAcademico>();

    public virtual ICollection<RhuTFicAntAcademico> RhuTFicAntAcademicoPItmInstEducs { get; } = new List<RhuTFicAntAcademico>();

    public virtual ICollection<RhuTFicAntAcademico> RhuTFicAntAcademicoPItmNivEducs { get; } = new List<RhuTFicAntAcademico>();

    public virtual ICollection<RhuTFicAntAcademico> RhuTFicAntAcademicoPItmTitulos { get; } = new List<RhuTFicAntAcademico>();

    public virtual ICollection<RhuTFicAntApv> RhuTFicAntApvPItmEstApvs { get; } = new List<RhuTFicAntApv>();

    public virtual ICollection<RhuTFicAntApv> RhuTFicAntApvPItmFpagos { get; } = new List<RhuTFicAntApv>();

    public virtual ICollection<RhuTFicAntApv> RhuTFicAntApvPItmOrigenAhs { get; } = new List<RhuTFicAntApv>();

    public virtual ICollection<RhuTFicAntComplementario> RhuTFicAntComplementarios { get; } = new List<RhuTFicAntComplementario>();

    public virtual ICollection<RhuTFicAntEmergencium> RhuTFicAntEmergencia { get; } = new List<RhuTFicAntEmergencium>();

    public virtual ICollection<RhuTFicAntGrupoFamiliar> RhuTFicAntGrupoFamiliarPItmNivEducs { get; } = new List<RhuTFicAntGrupoFamiliar>();

    public virtual ICollection<RhuTFicAntGrupoFamiliar> RhuTFicAntGrupoFamiliarPItmParentescos { get; } = new List<RhuTFicAntGrupoFamiliar>();

    public virtual ICollection<RhuTFicAntGrupoFamiliar> RhuTFicAntGrupoFamiliarPItmSexos { get; } = new List<RhuTFicAntGrupoFamiliar>();

    public virtual ICollection<RhuTFicAntGrupoFamiliar> RhuTFicAntGrupoFamiliarPItmTipCargaAdis { get; } = new List<RhuTFicAntGrupoFamiliar>();

    public virtual ICollection<RhuTFicAntGrupoFamiliar> RhuTFicAntGrupoFamiliarPItmTipCargas { get; } = new List<RhuTFicAntGrupoFamiliar>();

    public virtual ICollection<RhuTFicAntIdioma> RhuTFicAntIdiomaPItmIdiEscs { get; } = new List<RhuTFicAntIdioma>();

    public virtual ICollection<RhuTFicAntIdioma> RhuTFicAntIdiomaPItmIdiHabs { get; } = new List<RhuTFicAntIdioma>();

    public virtual ICollection<RhuTFicAntIdioma> RhuTFicAntIdiomaPItmIdiLecs { get; } = new List<RhuTFicAntIdioma>();

    public virtual ICollection<RhuTFicAntIdioma> RhuTFicAntIdiomaPItmIdiomas { get; } = new List<RhuTFicAntIdioma>();

    public virtual ICollection<RhuTFicAntImponible> RhuTFicAntImponibles { get; } = new List<RhuTFicAntImponible>();

    public virtual ICollection<RhuTFicCertificacione> RhuTFicCertificaciones { get; } = new List<RhuTFicCertificacione>();

    public virtual ICollection<RhuTFicDctosFi> RhuTFicDctosFis { get; } = new List<RhuTFicDctosFi>();

    public virtual ICollection<RhuTFicPersona> RhuTFicPersonaPItmEstCivils { get; } = new List<RhuTFicPersona>();

    public virtual ICollection<RhuTFicPersona> RhuTFicPersonaPItmFicEstados { get; } = new List<RhuTFicPersona>();

    public virtual ICollection<RhuTFicPersona> RhuTFicPersonaPItmNacionalidads { get; } = new List<RhuTFicPersona>();

    public virtual ICollection<RhuTFicPersona> RhuTFicPersonaPItmSexos { get; } = new List<RhuTFicPersona>();

    public virtual ICollection<RhuTFlegMovCarAnu> RhuTFlegMovCarAnus { get; } = new List<RhuTFlegMovCarAnu>();

    public virtual ICollection<RhuTFlegMovCargo> RhuTFlegMovCargoFlegMcaEstadoNavigations { get; } = new List<RhuTFlegMovCargo>();

    public virtual ICollection<RhuTFlegMovCargo> RhuTFlegMovCargoFlegMcaTipoNavigations { get; } = new List<RhuTFlegMovCargo>();

    public virtual ICollection<RhuTFnqCalculo> RhuTFnqCalculos { get; } = new List<RhuTFnqCalculo>();

    public virtual ICollection<RhuTFnqSolicitudDet> RhuTFnqSolicitudDets { get; } = new List<RhuTFnqSolicitudDet>();

    public virtual ICollection<RhuTLicAccidente> RhuTLicAccidentePItmAgeAccs { get; } = new List<RhuTLicAccidente>();

    public virtual ICollection<RhuTLicAccidente> RhuTLicAccidentePItmIncAccs { get; } = new List<RhuTLicAccidente>();

    public virtual ICollection<RhuTLicAccidente> RhuTLicAccidentePItmTipAccs { get; } = new List<RhuTLicAccidente>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicaPItmEstLics { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicaPItmLugReps { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicaPItmTipLics { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicaPItmTipReps { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicaPItmTraReps { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicMedico> RhuTLicMedicoPItmEspMeds { get; } = new List<RhuTLicMedico>();

    public virtual ICollection<RhuTLicMedico> RhuTLicMedicoPItmProMeds { get; } = new List<RhuTLicMedico>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicaPItmEstLics { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicaPItmLugReps { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicaPItmTipReps { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicaPItmTraReps { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTParDiccionario> RhuTParDiccionarioPDtoDicTipCols { get; } = new List<RhuTParDiccionario>();

    public virtual ICollection<RhuTParDiccionario> RhuTParDiccionarioPDtoDicTipFiltros { get; } = new List<RhuTParDiccionario>();

    public virtual ICollection<RhuTParUsuariosOrg> RhuTParUsuariosOrgs { get; } = new List<RhuTParUsuariosOrg>();

    public virtual ICollection<RhuTParVigItem> RhuTParVigItems { get; } = new List<RhuTParVigItem>();

    public virtual ICollection<RhuTPerSolicitud> RhuTPerSolicituds { get; } = new List<RhuTPerSolicitud>();

    public virtual ICollection<RhuTResumenCalculo> RhuTResumenCalculos { get; } = new List<RhuTResumenCalculo>();

    public virtual ICollection<RhuTSelSolicitud> RhuTSelSolicitudPItmEstadoSols { get; } = new List<RhuTSelSolicitud>();

    public virtual ICollection<RhuTSelSolicitud> RhuTSelSolicitudPItmTpMotivos { get; } = new List<RhuTSelSolicitud>();

    public virtual ICollection<RhuTSelSolicitud> RhuTSelSolicitudPItmTpSolics { get; } = new List<RhuTSelSolicitud>();
}
