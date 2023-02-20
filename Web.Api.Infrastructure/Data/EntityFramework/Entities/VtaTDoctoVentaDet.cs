using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaDet
{
    public decimal DoctoVentaDetId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public decimal PPedidoMaterialDetId { get; set; }

    public decimal PDoctoVentaKitId { get; set; }

    public byte TipoItem { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PCategoriaId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PBodegaId { get; set; }

    public double DvdCantDoctoSol { get; set; }

    public double DvdCantDoctoPre { get; set; }

    public double DvdCantDoctoFac { get; set; }

    public double DvdCantDoctoDev { get; set; }

    public double DvdCantDoctoAnu { get; set; }

    public double PrecioUnitario { get; set; }

    public double PrecioUnitarioOriginal { get; set; }

    public double PrecioMinimo { get; set; }

    public decimal PListaPreCabId { get; set; }

    public double DvdPorcDescto1 { get; set; }

    public double DvdPorcDescto2 { get; set; }

    public decimal PRebateId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte DvdIndAfectoExento { get; set; }

    public byte DvdIndRetencion { get; set; }

    public byte DvdIndImptoEsp { get; set; }

    public byte DvdIndDistribuyeCcosto { get; set; }

    public short TdeCodigo { get; set; }

    public double DesctoPorc1 { get; set; }

    public byte DvdUsaPrecio { get; set; }

    public string DvdUsuarioPrecio { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string CodigoArticuloSku { get; set; } = null!;

    public double CostoMateriaPrima { get; set; }

    public double CostoProduccion { get; set; }

    public double CostoExterior { get; set; }

    public double CostoUtillaje { get; set; }

    public decimal PDvcDirId { get; set; }

    public byte AreaPrep { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PProductoKitId { get; set; }

    public decimal PProductoEspTecId { get; set; }

    public byte Reserva { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PUnidadMedStockId { get; set; }

    public double DvdCantDoctoStock { get; set; }

    public DateTime DvdFecDespacho { get; set; }

    public decimal PProductoCodId { get; set; }

    public byte TseCodigo { get; set; }

    public decimal PConvenioDetId { get; set; }

    public byte DvdIndEnProceso { get; set; }

    public decimal PDoctoVentaDetIdOrigen { get; set; }

    public decimal PGlbMotivoId { get; set; }

    public string DvdGlosaMotivo { get; set; } = null!;

    public double DvdPorcDescto3 { get; set; }

    public double DvdPorcDescto4 { get; set; }

    public double DvdPorcComision { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public double DvdKiloNeto { get; set; }

    public double DvdKiloBruto { get; set; }

    public short TemCodigo { get; set; }

    public short TcdCodigo { get; set; }

    public string CodEtiqueta { get; set; } = null!;

    public short TcjCodigo { get; set; }

    public decimal PReservaEnvioCabId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public double DvdCantContenedor { get; set; }

    public int DvdOrdenDetalle { get; set; }

    public byte CfgDlgImprimeComponente { get; set; }

    public double DvdCostoEstimado { get; set; }

    public decimal PMonedaCostoEstimadoId { get; set; }

    public double DvdCostoReal { get; set; }

    public decimal PMonedaCostoRealId { get; set; }
}
