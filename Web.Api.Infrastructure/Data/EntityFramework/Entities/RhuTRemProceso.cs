using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemProceso
{
    public decimal ProcRemId { get; set; }

    public decimal PEmpId { get; set; }

    public string PrRcodigo { get; set; } = null!;

    public string PrRdescripcion { get; set; } = null!;

    public byte PrRindActTot { get; set; }

    public decimal PItmTipProcRem { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CcpTConceptosCcpSdo> CcpTConceptosCcpSdos { get; } = new List<CcpTConceptosCcpSdo>();

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTCtoDistribucion> RhuTCtoDistribucions { get; } = new List<RhuTCtoDistribucion>();

    public virtual ICollection<RhuTCtoRetJudPago> RhuTCtoRetJudPagos { get; } = new List<RhuTCtoRetJudPago>();

    public virtual ICollection<RhuTRemProcesoConc> RhuTRemProcesoConcs { get; } = new List<RhuTRemProcesoConc>();

    public virtual ICollection<RhuTRemProcesosCont> RhuTRemProcesosConts { get; } = new List<RhuTRemProcesosCont>();

    public virtual ICollection<RhuTRemProcesosPer> RhuTRemProcesosPers { get; } = new List<RhuTRemProcesosPer>();
}
