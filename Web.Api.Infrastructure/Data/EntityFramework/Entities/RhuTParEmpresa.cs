using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParEmpresa
{
    public decimal PEmpId { get; set; }

    public string PemEtiqueta1 { get; set; } = null!;

    public string PemEtiqueta2 { get; set; } = null!;

    public string PemEtiqueta3 { get; set; } = null!;

    public byte PemTipoLecturaCarga { get; set; }

    public byte PemTopeImpoVariable { get; set; }

    public byte PemSobregiro { get; set; }

    public byte PemCargasProp { get; set; }

    public byte PemTipoCalculo18566 { get; set; }

    public byte PemTipCalcImpVarble { get; set; }

    public byte PemOrdenGrilla { get; set; }

    public byte PemIndImprimApo { get; set; }

    public byte PemTopeImpVarbleInc { get; set; }

    public decimal PMonedaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public byte PemIndImprimCon { get; set; }

    public string PemTipoImpresora { get; set; } = null!;

    public byte PemDiaEpe { get; set; }

    public byte PemInfLicAus { get; set; }

    public short ParOrgCod { get; set; }

    public decimal PEmpPais { get; set; }

    public decimal PEmpOrganigrama { get; set; }

    public string PEmpRutaCartaOferta { get; set; } = null!;

    public string PEmpRutaAnexoCartOfer { get; set; } = null!;

    public string PEmpRutaCv { get; set; } = null!;

    public string PemGlosaLiq { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTApvcEmpresa> RhuTApvcEmpresas { get; } = new List<RhuTApvcEmpresa>();

    public virtual RhuTBieEmpConf? RhuTBieEmpConf { get; set; }

    public virtual ICollection<RhuTCtoAnxContrato> RhuTCtoAnxContratos { get; } = new List<RhuTCtoAnxContrato>();

    public virtual ICollection<RhuTCtoConfiguracion> RhuTCtoConfiguracions { get; } = new List<RhuTCtoConfiguracion>();

    public virtual ICollection<RhuTCtoContrato> RhuTCtoContratos { get; } = new List<RhuTCtoContrato>();

    public virtual ICollection<RhuTCtoNominasCf> RhuTCtoNominasCfs { get; } = new List<RhuTCtoNominasCf>();

    public virtual ICollection<RhuTCtoReajuste> RhuTCtoReajustes { get; } = new List<RhuTCtoReajuste>();

    public virtual ICollection<RhuTCtoSolActivar> RhuTCtoSolActivars { get; } = new List<RhuTCtoSolActivar>();

    public virtual ICollection<RhuTCtoSolCambio> RhuTCtoSolCambios { get; } = new List<RhuTCtoSolCambio>();

    public virtual ICollection<RhuTDrtFormatoDecl> RhuTDrtFormatoDecls { get; } = new List<RhuTDrtFormatoDecl>();

    public virtual ICollection<RhuTExcEmpresa> RhuTExcEmpresas { get; } = new List<RhuTExcEmpresa>();

    public virtual ICollection<RhuTFlegBitacora> RhuTFlegBitacoras { get; } = new List<RhuTFlegBitacora>();

    public virtual ICollection<RhuTFnqSolicitud> RhuTFnqSolicituds { get; } = new List<RhuTFnqSolicitud>();

    public virtual ICollection<RhuTParEstrOrganica> RhuTParEstrOrganicas { get; } = new List<RhuTParEstrOrganica>();

    public virtual ICollection<RhuTParVigDatosLeg> RhuTParVigDatosLegs { get; } = new List<RhuTParVigDatosLeg>();

    public virtual ICollection<RhuTRemProceso> RhuTRemProcesos { get; } = new List<RhuTRemProceso>();
}
