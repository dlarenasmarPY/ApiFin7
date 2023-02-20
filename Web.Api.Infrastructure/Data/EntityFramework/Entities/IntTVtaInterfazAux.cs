using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTVtaInterfazAux
{
    public string IntTmpOwner { get; set; } = null!;

    public decimal PDoctoVentaDetId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public byte TipoItem { get; set; }

    public string ProductoCod { get; set; } = null!;

    public string ServicioCod { get; set; } = null!;

    public string CategoriaCod { get; set; } = null!;

    public string UnidadMedCod { get; set; } = null!;

    public string UnidadMedCodStock { get; set; } = null!;

    public DateTime DvdFecDespacho { get; set; }

    public int BodegaCod { get; set; }

    public double DvdCantDoctoSol { get; set; }

    public double DvdCantDoctoStock { get; set; }

    public double PrecioUnitario { get; set; }

    public double PrecioUnitarioOriginal { get; set; }

    public double PrecioMinimo { get; set; }

    public decimal PListaPreCabId { get; set; }

    public int CreCodigo { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte DvdIndAfectoExento { get; set; }

    public byte DvdIndRetencion { get; set; }

    public byte DvdIndImptoEsp { get; set; }

    public byte DvdIndDistribuyeCcosto { get; set; }

    public byte TseCodigo { get; set; }

    public short TdeCodigo { get; set; }

    public double DesctoPorc1 { get; set; }

    public string IntBitArchivo { get; set; } = null!;

    public int CabOpeLinea { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PCategoriaId { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PProductoCodId { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }
}
