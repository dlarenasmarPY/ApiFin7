using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTSolicitudAjusteDet
{
    public decimal SolicitudAjusteDetId { get; set; }

    public decimal PSolicitudAjusteCabId { get; set; }

    public byte TipoItem { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public double SadCantidad { get; set; }

    public double PrecioUnitario { get; set; }

    public double DldPrecioUnitario { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte DldIndAfectoExento { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public byte ConEstCod { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte DldIndRetencion { get; set; }

    public byte DldIndImptoEsp { get; set; }

    public byte TseCodigo { get; set; }

    public decimal PProductoKitId { get; set; }

    public decimal PDetReferenciaKitId { get; set; }
}
