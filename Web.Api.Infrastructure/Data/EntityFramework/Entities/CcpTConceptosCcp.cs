using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTConceptosCcp
{
    public decimal ConceptoCcpId { get; set; }

    public short ConCcpCod { get; set; }

    public string ConCcpGlosa { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public DateTime ConCcpFecVigencia { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PTprId { get; set; }

    public short TdoId { get; set; }

    public decimal PMonedaId { get; set; }

    public short ConCcpMaxCuotas { get; set; }

    public double ConCcpMaxMonto { get; set; }

    public string ConCcpReaInt { get; set; } = null!;

    public byte ConCcpTipIntRea { get; set; }

    public double ConCcpTasa { get; set; }

    public byte ConCcpIndDevol { get; set; }

    public short ConCcpPeriodicidad { get; set; }

    public byte ConCcpTipRendicion { get; set; }

    public byte DetCcpTipoLinea { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCtaIntId { get; set; }

    public decimal PCreIntId { get; set; }

    public int CdiCodigoInt { get; set; }

    public string PryNumeroInt { get; set; } = null!;

    public decimal PTprIntId { get; set; }

    public short TdoIntId { get; set; }

    public virtual ICollection<CcpTCompromiso> CcpTCompromisos { get; } = new List<CcpTCompromiso>();

    public virtual ICollection<CcpTConceptosCcpSdo> CcpTConceptosCcpSdos { get; } = new List<CcpTConceptosCcpSdo>();

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;
}
