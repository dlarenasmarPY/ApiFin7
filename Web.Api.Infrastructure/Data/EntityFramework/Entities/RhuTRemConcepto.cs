using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemConcepto
{
    public decimal ConcRemId { get; set; }

    public decimal PEmpId { get; set; }

    public string CnRcodigo { get; set; } = null!;

    public string CnRdescripcion { get; set; } = null!;

    public byte CnRnivActualizacion { get; set; }

    public string CnRtipo { get; set; } = null!;

    public string CnRtipoVariable { get; set; } = null!;

    public string CnRtipoFormula { get; set; } = null!;

    public short CnRtipoDato { get; set; }

    public byte CnRindReliquidacion { get; set; }

    public byte CnRindCorrUtmacc { get; set; }

    public byte CnRindCalculoDif { get; set; }

    public decimal? CnRactDatoTbMid { get; set; }

    public decimal? CnRactDatoAtrMid { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CcpTConceptosCcpSdo> CcpTConceptosCcpSdos { get; } = new List<CcpTConceptosCcpSdo>();

    public virtual RhuTRemTblAtribModelo? CnRactDatoAtrM { get; set; }

    public virtual ICollection<RhuTCtoRenta> RhuTCtoRenta { get; } = new List<RhuTCtoRenta>();

    public virtual RhuTCtoSubsidio? RhuTCtoSubsidio { get; set; }

    public virtual ICollection<RhuTExcEmpresa> RhuTExcEmpresas { get; } = new List<RhuTExcEmpresa>();

    public virtual ICollection<RhuTExcTipPago> RhuTExcTipPagos { get; } = new List<RhuTExcTipPago>();

    public virtual ICollection<RhuTFlegDefGral> RhuTFlegDefGralPConcRemFlNavigations { get; } = new List<RhuTFlegDefGral>();

    public virtual ICollection<RhuTFlegDefGral> RhuTFlegDefGralPConcRemPrNavigations { get; } = new List<RhuTFlegDefGral>();

    public virtual ICollection<RhuTFlegDefGral> RhuTFlegDefGralPConcRems { get; } = new List<RhuTFlegDefGral>();

    public virtual ICollection<RhuTRemConceptosCont> RhuTRemConceptosConts { get; } = new List<RhuTRemConceptosCont>();

    public virtual ICollection<RhuTRemConceptosMe> RhuTRemConceptosMes { get; } = new List<RhuTRemConceptosMe>();

    public virtual ICollection<RhuTRemConceptosPer> RhuTRemConceptosPers { get; } = new List<RhuTRemConceptosPer>();

    public virtual ICollection<RhuTRemConceptosTot> RhuTRemConceptosTots { get; } = new List<RhuTRemConceptosTot>();

    public virtual ICollection<RhuTRemLiqDetalle> RhuTRemLiqDetalles { get; } = new List<RhuTRemLiqDetalle>();

    public virtual ICollection<RhuTRemNominasConcDet> RhuTRemNominasConcDets { get; } = new List<RhuTRemNominasConcDet>();

    public virtual ICollection<RhuTRemPermanente> RhuTRemPermanentes { get; } = new List<RhuTRemPermanente>();

    public virtual ICollection<RhuTRemProcesoConc> RhuTRemProcesoConcs { get; } = new List<RhuTRemProcesoConc>();
}
