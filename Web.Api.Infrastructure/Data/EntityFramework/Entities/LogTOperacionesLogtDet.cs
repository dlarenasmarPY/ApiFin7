using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDet
{
    public decimal OpeLogtDetId { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public int Linea { get; set; }

    public decimal PDocOrigenDetId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte IndControlCalidad { get; set; }

    public byte IndicaSerie { get; set; }

    public byte IndicaLote { get; set; }

    public decimal PBodegaId { get; set; }

    public byte IndDescripDoc { get; set; }

    public double CantDocOrigen { get; set; }

    public double CantEntrada { get; set; }

    public double CantSalida { get; set; }

    public decimal PUnidadMedOrigenId { get; set; }

    public double ControlCalidadPorc { get; set; }

    public double ValorUniOpeMonedaOrigen { get; set; }

    public double TasaCambio { get; set; }

    public decimal PMonedaOrigenId { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorUniOpeMonedaAlt { get; set; }

    public double ValorOpeMoneda { get; set; }

    public double ValorOpeMonedaAlt { get; set; }

    public double CantBodegaOrigen { get; set; }

    public double UnidadMedConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public double Cantidad { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double CantDocOrigen2 { get; set; }

    public double CantEntrada2 { get; set; }

    public double CantSalida2 { get; set; }

    public double Cantidad2 { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal RefControlCalidad { get; set; }

    public double ValorUniOpeMonedaCorregido { get; set; }

    public double ValorOpeMonedaCorregido { get; set; }

    public double CostoMonedaCorregido { get; set; }

    public double CostoPromMonedaCorregido { get; set; }

    public string LogOwner { get; set; } = null!;

    public double CantEntradaStock { get; set; }

    public double CantSalidaStock { get; set; }

    public byte EntradaSalida { get; set; }

    public byte IndAjusteComplementario { get; set; }

    public double ValorUniOpeMonedaSinCorr { get; set; }

    public double ValorOpeMonedaSinCorr { get; set; }

    public int ItemDet { get; set; }

    public double CantEntradaTotal { get; set; }

    public double CantSalidaTotal { get; set; }

    public double CantEntradaTotal2 { get; set; }

    public double CantSalidaTotal2 { get; set; }

    public decimal PLoteProductoDetId { get; set; }

    public decimal PUbicacionDetId { get; set; }

    public byte IndRedespacho { get; set; }

    public decimal PCierreDlgId { get; set; }

    public decimal POpeLogtCabFifoId { get; set; }

    public double ValorPetroleo { get; set; }

    public string GlosaExisDet { get; set; } = null!;

    public double CantidadPreparadaKit { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public virtual ICollection<LogTOperacionesLogtDetCont> LogTOperacionesLogtDetConts { get; } = new List<LogTOperacionesLogtDetCont>();

    public virtual ICollection<LogTOperacionesLogtDetSerieLote> LogTOperacionesLogtDetSerieLotes { get; } = new List<LogTOperacionesLogtDetSerieLote>();

    public virtual ICollection<LogTOperacionesLogtDetUbicacion> LogTOperacionesLogtDetUbicacions { get; } = new List<LogTOperacionesLogtDetUbicacion>();

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual LogTOperacionesLogtCab POpeLogtCab { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedOrigen { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedStock { get; set; } = null!;

    public virtual LogTSituacionContable SituacionContCodNavigation { get; set; } = null!;
}
