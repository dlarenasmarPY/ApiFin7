using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTMovimiento
{
    public decimal DetCcpId { get; set; }

    public decimal POpeCcpId { get; set; }

    public int DetCcpNroLinea { get; set; }

    public int DetCcpNroCuota { get; set; }

    public decimal PConceptoGastoId { get; set; }

    public DateTime DetCcpFechaVenc { get; set; }

    public double DetCcpMontoLocalDebe { get; set; }

    public double DetCcpMontoLocalHaber { get; set; }

    public double DetCcpMontoImpuDebe { get; set; }

    public double DetCcpMontoImpuHaber { get; set; }

    public double DetCcpMontoConvDebe { get; set; }

    public double DetCcpMontoConvHaber { get; set; }

    public byte DetCcpTipoLinea { get; set; }

    public byte SisCodOri { get; set; }

    public short PerId { get; set; }

    public short UniCodigo { get; set; }

    public decimal PCabOpeId { get; set; }

    public int CabOpeLinea { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PTprId { get; set; }

    public short TdoId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PEntIdPago { get; set; }

    public decimal PMovTesId { get; set; }

    public decimal PDetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public decimal PFormaPagoId { get; set; }

    public short UniCodigoEmi { get; set; }

    public decimal PEmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public decimal PDocFisId { get; set; }

    public string DetCcpGlosa { get; set; } = null!;

    public byte DetCcpEstado { get; set; }

    public DateTime CabOpePagFec { get; set; }

    public decimal PCabOpeIdOri { get; set; }

    public int CabOpeLineaOri { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public int MovCcpConNumero { get; set; }

    public DateTime MovCcpConFecha { get; set; }

    public string DetCcpOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCabOpeIntId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int MovIdRelEscenario { get; set; }

    public byte MarcaComplemento { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public string IndGenCuota { get; set; } = null!;

    public int InstCod { get; set; }

    public short EntSucInstSuc { get; set; }

    public string EntSucCodCtaCteBco { get; set; } = null!;

    public virtual CcpTMovtosGto? CcpTMovtosGto { get; set; }

    public virtual CcpTConceptosGasto PConceptoGasto { get; set; } = null!;

    public virtual CcpTCompromiso POpeCcp { get; set; } = null!;
}
