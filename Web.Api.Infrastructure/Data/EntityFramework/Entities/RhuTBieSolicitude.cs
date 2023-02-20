using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieSolicitude
{
    public decimal BieSolId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short EjeAno { get; set; }

    public decimal PBieSocId { get; set; }

    public decimal PBeneficiosId { get; set; }

    public decimal PBenTopId { get; set; }

    public DateTime FecSolicitud { get; set; }

    public short SeqLinea { get; set; }

    public string EntRut2 { get; set; } = null!;

    public decimal TipoBeneficio { get; set; }

    public byte IndBeneficiario { get; set; }

    public decimal ValSolicitud { get; set; }

    public decimal ValIsapre { get; set; }

    public decimal ValSeguros { get; set; }

    public decimal ValAprobado { get; set; }

    public decimal ValBonificacion { get; set; }

    public decimal ValMoneda { get; set; }

    public decimal PBieEleFpago { get; set; }

    public decimal PNomConcDetId { get; set; }

    public string GlosaBenef { get; set; } = null!;

    public int DocNumInterno { get; set; }

    public DateTime FechaPago { get; set; }

    public string Observacion { get; set; } = null!;

    public decimal NumBoleta { get; set; }

    public decimal PBiePrestId { get; set; }

    public DateTime FecDesde { get; set; }

    public DateTime FecHasta { get; set; }

    public decimal ValBoleta { get; set; }

    public string ObsBoleta { get; set; } = null!;

    public decimal PBieEleId { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PEmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public double DetBieMontoLocalDebe { get; set; }

    public double DetBieMontoLocalHaber { get; set; }

    public double DetBieMontoImpuDebe { get; set; }

    public double DetBieMontoImpuHaber { get; set; }

    public double DetBieMontoConvDebe { get; set; }

    public double DetBieMontoConvHaber { get; set; }

    public byte SisCodOri { get; set; }

    public short PerId { get; set; }

    public decimal PCabOpeId { get; set; }

    public int CabOpeLinea { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PPryId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PTprId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PEntIdPago { get; set; }

    public decimal PMovTesId { get; set; }

    public decimal PDetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public decimal PFormaPagoId { get; set; }

    public decimal PCabOpeIdOri { get; set; }

    public int CabOpeLineaOri { get; set; }

    public DateTime CabOpePagFec { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public int MovCcpConNumero { get; set; }

    public DateTime MovCcpConFecha { get; set; }

    public decimal PCabOpeIntId { get; set; }

    public short TdoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int MovIdRelEscenario { get; set; }

    public byte MarcaComplemento { get; set; }

    public virtual RhuTBieBeneficiosTope PBenTop { get; set; } = null!;

    public virtual RhuTBieBeneficio PBeneficios { get; set; } = null!;

    public virtual RhuTParItem PBieEle { get; set; } = null!;

    public virtual RhuTParItem PBieEleFpagoNavigation { get; set; } = null!;

    public virtual RhuTBiePrestadore PBiePrest { get; set; } = null!;

    public virtual RhuTBieSocio PBieSoc { get; set; } = null!;

    public virtual RhuTParItem TipoBeneficioNavigation { get; set; } = null!;
}
