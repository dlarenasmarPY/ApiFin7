using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTConvenioCab
{
    public decimal ConvenioCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public byte SisCodOri { get; set; }

    public int CocNumConvenio { get; set; }

    public string CocDescripcion { get; set; } = null!;

    public short TcpCodigo { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PCondPagoId { get; set; }

    public byte CocUsaMandatorio { get; set; }

    public byte CocUsaHolding { get; set; }

    public string CocReferencia { get; set; } = null!;

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public double CocPorcDescto1 { get; set; }

    public double CocPorcDescto2 { get; set; }

    public double CocPorcDescto3 { get; set; }

    public double CocPorcDescto4 { get; set; }

    public byte TirId { get; set; }

    public double CocFactorReajuste { get; set; }

    public short CocPeriodoReajuste { get; set; }

    public DateTime CocFecBaseReajuste { get; set; }

    public double CocUltFactorReajuste { get; set; }

    public DateTime CocUltFechaReajuste { get; set; }

    public byte IndDiferido { get; set; }

    public int CocCantDiferido { get; set; }

    public DateTime CocUltFechaDiferido { get; set; }

    public string CocUsuarioDiferido { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public short PlazoNormalPago { get; set; }

    public short PlazoPrePago { get; set; }

    public double DesctoPorcPrepago { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PUbicacionId { get; set; }

    public string CocGlosa { get; set; } = null!;

    public string CocGlosaCierre { get; set; } = null!;

    public string CodOwner { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PConvenioCabOrigenId { get; set; }

    public short CocNumVersion { get; set; }

    public decimal PPuertoDestino { get; set; }

    public decimal PClausulaVenta { get; set; }

    public decimal PFormaPagoId { get; set; }

    public decimal PEntComisionistaId { get; set; }

    public decimal PEntSucComisionistaId { get; set; }

    public double CocPorcComisionista { get; set; }

    public short TppCodigo { get; set; }

    public byte CocUsaPrecioFob { get; set; }
}
