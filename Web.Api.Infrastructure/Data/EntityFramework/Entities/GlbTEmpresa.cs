using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEmpresa
{
    public decimal EmpId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public string EmpRutrepLegal { get; set; } = null!;

    public string EmpNomRepLegal { get; set; } = null!;

    public string EmpRutcontGeneral { get; set; } = null!;

    public string EmpNomContGeneral { get; set; } = null!;

    public DateTime EmpFecIniActividad { get; set; }

    public byte EmpMesInicioEjercicio { get; set; }

    public byte EmpFilial { get; set; }

    public DateTime EmpFecIniTransac { get; set; }

    public byte EmpIndEmiElectronico { get; set; }

    public DateTime EmpFecAutorizaSii { get; set; }

    public decimal EmpNumResolucion { get; set; }

    public decimal PEntIdAdmDte { get; set; }

    public string EmpMailContactoSii { get; set; } = null!;

    public string EmpMailContactoEmp { get; set; } = null!;

    public byte EmpIndCertificacion { get; set; }

    public byte EmpIndImprimeDte { get; set; }

    public byte EmpUsaLprecio { get; set; }

    public string EmpRolCredito { get; set; } = null!;

    public string EmpRolComercial { get; set; } = null!;

    public string EmpRolLogistico { get; set; } = null!;

    public string EmpRolOtro { get; set; } = null!;

    public short EmpMaxDocumentos { get; set; }

    public byte EmpIndRecepcionaLc { get; set; }

    public byte EmpIndDescto { get; set; }

    public string EmpIndCertDesctoGlobal { get; set; } = null!;

    public byte EmpUsaProvDteExterno { get; set; }

    public string EmpNumRegContador { get; set; } = null!;

    public string EmpMailTexto { get; set; } = null!;

    public short FormaPagoCodExt { get; set; }

    public byte EmpIndAmbiente { get; set; }

    public virtual ICollection<AdqTConfiguracion> AdqTConfiguracions { get; } = new List<AdqTConfiguracion>();

    public virtual ICollection<AdqTOcCab> AdqTOcCabs { get; } = new List<AdqTOcCab>();

    public virtual ICollection<AdqTRolUsuarioEmp> AdqTRolUsuarioEmps { get; } = new List<AdqTRolUsuarioEmp>();

    public virtual ICollection<CceTDocumento> CceTDocumentos { get; } = new List<CceTDocumento>();

    public virtual ICollection<CceTMovimiento> CceTMovimientos { get; } = new List<CceTMovimiento>();

    public virtual ICollection<CcpTConceptosCcp> CcpTConceptosCcps { get; } = new List<CcpTConceptosCcp>();

    public virtual ICollection<CcpTConceptosGasto> CcpTConceptosGastos { get; } = new List<CcpTConceptosGasto>();

    public virtual ICollection<ConTCabeceraCom> ConTCabeceraComs { get; } = new List<ConTCabeceraCom>();

    public virtual ICollection<ConTCabeceraOpe> ConTCabeceraOpes { get; } = new List<ConTCabeceraOpe>();

    public virtual ICollection<ConTMovimiento> ConTMovimientos { get; } = new List<ConTMovimiento>();

    public virtual ICollection<IsaTMovimiento> IsaTMovimientos { get; } = new List<IsaTMovimiento>();

    public virtual ICollection<LogTCorrelativo> LogTCorrelativos { get; } = new List<LogTCorrelativo>();

    public virtual ICollection<LogTOperacionesLogtCab> LogTOperacionesLogtCabs { get; } = new List<LogTOperacionesLogtCab>();

    public virtual ICollection<LogTPedidoMaterialCab> LogTPedidoMaterialCabs { get; } = new List<LogTPedidoMaterialCab>();

    public virtual ICollection<LogTTipoOpeEntidad> LogTTipoOpeEntidads { get; } = new List<LogTTipoOpeEntidad>();

    public virtual RhuTParEmpresa? RhuTParEmpresa { get; set; }

    public virtual ICollection<RhuTSelSolicitud> RhuTSelSolicituds { get; } = new List<RhuTSelSolicitud>();

    public virtual ICollection<TesTMovimiento> TesTMovimientos { get; } = new List<TesTMovimiento>();
}
