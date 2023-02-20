using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcDet
{
    public decimal OcDetId { get; set; }

    public decimal POcCabId { get; set; }

    public decimal PCotizDetId { get; set; }

    public int Linea { get; set; }

    public int Item { get; set; }

    public DateTime FechaEntrega { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PProductoCodId { get; set; }

    public byte IndControlCalidad { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PCconsumoId { get; set; }

    public decimal PDocOrigenDetId { get; set; }

    public double CantDocOrigen { get; set; }

    public double CantMinimaComp { get; set; }

    public double CantidadCompraHist { get; set; }

    public double CantidadCompra { get; set; }

    public decimal PUnidadMedCompraId { get; set; }

    public double UnidadMedConversion { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public double CantidadStock { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public double CantPendiente { get; set; }

    public byte UnidadMedPeso { get; set; }

    public byte UnidadMedVolumen { get; set; }

    public double ImpAdicionalPorc { get; set; }

    public double ImpOtroPorc { get; set; }

    public double RetencionPorc { get; set; }

    public byte IndExento { get; set; }

    public double Iva { get; set; }

    public decimal PListaPreDetId { get; set; }

    public double PrecioUniHist { get; set; }

    public double PrecioUni { get; set; }

    public double DesctoPorc1 { get; set; }

    public double DesctoPorc2 { get; set; }

    public double DesctoPorc3 { get; set; }

    public double DesctoPorc4 { get; set; }

    public double TotalDesctoPorc { get; set; }

    public double ValorTotal { get; set; }

    public double TotalDesctoItem { get; set; }

    public double ValorTotalDescto { get; set; }

    public double TotalDesctoGral { get; set; }

    public double DesctoProntoPago { get; set; }

    public double ValorTotalCompra { get; set; }

    public double ValorUniCompra { get; set; }

    public double TotalFlete { get; set; }

    public double TotalAfeIva { get; set; }

    public double TotalExeIva { get; set; }

    public double TotalIva { get; set; }

    public double TotalImpuestoAdi { get; set; }

    public double TotalImpuestoOtro { get; set; }

    public double TotalRetencion { get; set; }

    public double TotalCompraItem { get; set; }

    public string AdqGlosa { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string UsuarioCierrePend { get; set; } = null!;

    public DateTime FechaCierrePend { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double UnidadMedValorPeso { get; set; }

    public double UnidadMedValorVolumen { get; set; }

    public decimal PConvenioDetId { get; set; }

    public decimal PImpRetencionId { get; set; }

    public double CantidadUniMedBase { get; set; }

    public decimal PUnidadMedBaseId { get; set; }

    public double TasaBase { get; set; }

    public double ValorCombustMonedaBase { get; set; }

    public double ValorCombustMonedaLocal { get; set; }

    public decimal PMonedaBaseId { get; set; }

    public double ValorCombustVariable { get; set; }

    public double ValorImptoCombust { get; set; }

    public byte IndAfectaCosto { get; set; }

    public DateTime FechaCompromisoProv { get; set; }

    public DateTime FechaEntregaRealProv { get; set; }

    public virtual ICollection<AdqTOcDetCont> AdqTOcDetConts { get; } = new List<AdqTOcDetCont>();

    public virtual ICollection<AdqTOcDetEspTec> AdqTOcDetEspTecs { get; } = new List<AdqTOcDetEspTec>();

    public virtual ICollection<AdqTOcDetGlosa> AdqTOcDetGlosas { get; } = new List<AdqTOcDetGlosa>();

    public virtual AdqTOcCab POcCab { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedCompra { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedStock { get; set; } = null!;
}
