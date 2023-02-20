using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoContrato
{
    public decimal CtoId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal CtoNumero { get; set; }

    public string CtoSecuencia { get; set; } = null!;

    public DateTime CtoFecVigencia { get; set; }

    public DateTime CtoFecRenovacion { get; set; }

    public DateTime CtoFecCompromiso { get; set; }

    public DateTime CtoFecAntiguedad { get; set; }

    public DateTime CtoFecFiniquito { get; set; }

    public decimal PItmTpContratoId { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PItmTpRtaId { get; set; }

    public decimal PItmTpImptoId { get; set; }

    public decimal PItmCategoriaId { get; set; }

    public decimal PItmCalJurId { get; set; }

    public short CtoJornada { get; set; }

    public decimal PItmJornadaId { get; set; }

    public byte CtoIndSegCes { get; set; }

    public decimal PCreId { get; set; }

    public decimal PItmLugarPagoId { get; set; }

    public decimal PLugId { get; set; }

    public decimal PItmGruConId { get; set; }

    public decimal PItmIntegroId { get; set; }

    public decimal PCcafEntId { get; set; }

    public byte CtoIndMutual { get; set; }

    public decimal PMutualEntId { get; set; }

    public decimal PMutualEntSucId { get; set; }

    public decimal PSdeId { get; set; }

    public decimal PFnqSolDetId { get; set; }

    public decimal PItmCtoEstado { get; set; }

    public int CtoPeriodoDesde { get; set; }

    public int CtoPeriodoControl { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CtoIndSegCes11 { get; set; }

    public byte CtoIndAccInf { get; set; }

    public virtual ICollection<CcpTCompromiso> CcpTCompromisos { get; } = new List<CcpTCompromiso>();

    public virtual ConTCentrosResp PCre { get; set; } = null!;

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmCalJur { get; set; } = null!;

    public virtual RhuTParItem PItmCategoria { get; set; } = null!;

    public virtual RhuTParItem PItmIntegro { get; set; } = null!;

    public virtual RhuTParItem PItmJornada { get; set; } = null!;

    public virtual RhuTParItem PItmLugarPago { get; set; } = null!;

    public virtual RhuTParItem PItmTpContrato { get; set; } = null!;

    public virtual RhuTParItem PItmTpImpto { get; set; } = null!;

    public virtual RhuTParItem PItmTpRta { get; set; } = null!;

    public virtual RhuTParLugarTrabajo PLug { get; set; } = null!;

    public virtual ICollection<RhuTApvcAfiliado> RhuTApvcAfiliados { get; } = new List<RhuTApvcAfiliado>();

    public virtual ICollection<RhuTCapEjeNomina> RhuTCapEjeNominas { get; } = new List<RhuTCapEjeNomina>();

    public virtual ICollection<RhuTCapPlanesDet> RhuTCapPlanesDets { get; } = new List<RhuTCapPlanesDet>();

    public virtual ICollection<RhuTCapPostulantesDet> RhuTCapPostulantesDets { get; } = new List<RhuTCapPostulantesDet>();

    public virtual ICollection<RhuTCtoAfiliacionVol> RhuTCtoAfiliacionVols { get; } = new List<RhuTCtoAfiliacionVol>();

    public virtual ICollection<RhuTCtoAfiliacione> RhuTCtoAfiliaciones { get; } = new List<RhuTCtoAfiliacione>();

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratos { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoDistribucion> RhuTCtoDistribucions { get; } = new List<RhuTCtoDistribucion>();

    public virtual ICollection<RhuTCtoNominasCfdet> RhuTCtoNominasCfdets { get; } = new List<RhuTCtoNominasCfdet>();

    public virtual RhuTCtoObraFaena? RhuTCtoObraFaena { get; set; }

    public virtual ICollection<RhuTCtoReajustesDet> RhuTCtoReajustesDets { get; } = new List<RhuTCtoReajustesDet>();

    public virtual ICollection<RhuTCtoRenta> RhuTCtoRenta { get; } = new List<RhuTCtoRenta>();

    public virtual ICollection<RhuTCtoRetJudiciale> RhuTCtoRetJudiciales { get; } = new List<RhuTCtoRetJudiciale>();

    public virtual ICollection<RhuTCtoSolActivar> RhuTCtoSolActivars { get; } = new List<RhuTCtoSolActivar>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambios { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTCtoSolicitude> RhuTCtoSolicitudes { get; } = new List<RhuTCtoSolicitude>();

    public virtual ICollection<RhuTEpeSolicitude> RhuTEpeSolicitudes { get; } = new List<RhuTEpeSolicitude>();

    public virtual ICollection<RhuTFlegDatosAdic> RhuTFlegDatosAdics { get; } = new List<RhuTFlegDatosAdic>();

    public virtual ICollection<RhuTFlegMovAbono> RhuTFlegMovAbonos { get; } = new List<RhuTFlegMovAbono>();

    public virtual ICollection<RhuTFlegMovCarAnu> RhuTFlegMovCarAnus { get; } = new List<RhuTFlegMovCarAnu>();

    public virtual ICollection<RhuTFlegMovCargo> RhuTFlegMovCargos { get; } = new List<RhuTFlegMovCargo>();

    public virtual ICollection<RhuTFnqSolicitudDet> RhuTFnqSolicitudDets { get; } = new List<RhuTFnqSolicitudDet>();

    public virtual ICollection<RhuTFnqSolicitud> RhuTFnqSolicituds { get; } = new List<RhuTFnqSolicitud>();

    public virtual ICollection<RhuTLicAccidente> RhuTLicAccidentes { get; } = new List<RhuTLicAccidente>();

    public virtual ICollection<RhuTLicMedica> RhuTLicMedicas { get; } = new List<RhuTLicMedica>();

    public virtual ICollection<RhuTLicRmedica> RhuTLicRmedicas { get; } = new List<RhuTLicRmedica>();

    public virtual ICollection<RhuTPerSolicitud> RhuTPerSolicituds { get; } = new List<RhuTPerSolicitud>();

    public virtual ICollection<RhuTPerVacGanada> RhuTPerVacGanada { get; } = new List<RhuTPerVacGanada>();

    public virtual ICollection<RhuTRemLiqAntecedente> RhuTRemLiqAntecedentes { get; } = new List<RhuTRemLiqAntecedente>();

    public virtual ICollection<RhuTRemNominasConcDet> RhuTRemNominasConcDets { get; } = new List<RhuTRemNominasConcDet>();

    public virtual ICollection<RhuTRemPermanente> RhuTRemPermanentes { get; } = new List<RhuTRemPermanente>();

    public virtual ICollection<RhuTResumenCalculo> RhuTResumenCalculos { get; } = new List<RhuTResumenCalculo>();
}
