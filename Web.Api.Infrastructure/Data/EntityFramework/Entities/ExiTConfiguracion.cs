using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte IndicaUbicacion { get; set; }

    public byte IndicaPicking { get; set; }

    public byte IndicaPickingDirecto { get; set; }

    public byte IndicaValorizacionSaldos { get; set; }

    public byte IndLectorBarra { get; set; }

    public byte IndCorrTipoOpe { get; set; }

    public byte PedidoTipoRecepcion { get; set; }

    public byte IndicaBodDestinoDif { get; set; }

    public decimal PBodDestinoDifId { get; set; }

    public short TdoIdDesp { get; set; }

    public short TdoIdDespInt { get; set; }

    public short TdoIdDev { get; set; }

    public short TdoIdCv { get; set; }

    public short TdoIdCm { get; set; }

    public byte NumLineaDoctoLegal { get; set; }

    public byte TipoCentralizacionCont { get; set; }

    public byte TipoSerie { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndValorizaLote { get; set; }

    public byte IndUnidadMedLog { get; set; }

    public byte IndPorcHolgura { get; set; }

    public double FactorGd { get; set; }

    public decimal PTipoOpeContVnrid { get; set; }

    public decimal PCtaProvisionVnrid { get; set; }

    public decimal PCtaExistencias2Id { get; set; }

    public decimal PCctaOtrosVnrid { get; set; }

    public decimal PCctaVentasVnrid { get; set; }

    public decimal PCctaActivoVnrid { get; set; }

    public byte FormaAtencionCodStock { get; set; }

    public decimal PTipoOpeAjuComplId { get; set; }

    public short NumDiasParaRecep { get; set; }

    public short NumDiasParaDespa { get; set; }

    public byte ContabilizaEfectoTributario { get; set; }

    public byte PartNumberObligatorio { get; set; }

    public byte BloqueoDespacho { get; set; }

    public byte DestinatariaTraspaso { get; set; }

    public byte? UsoLiquidaConsumo { get; set; }

    public int PServicioIdDpc { get; set; }

    public byte IndManejaSoloStock { get; set; }

    public byte IndCompraRecepPend { get; set; }

    public byte ValidaRotulo { get; set; }

    public byte PermiteDevVentas { get; set; }

    public byte IncValorDoc { get; set; }

    public byte IndTipoCm { get; set; }
}
