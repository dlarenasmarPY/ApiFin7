using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTCambioSujetoDet
{
    public decimal CambioSujetoDetId { get; set; }

    public decimal PCambioSujetoCabId { get; set; }

    public short CsdItem { get; set; }

    public byte DldTipoCodigo { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public double CsdCantidad { get; set; }

    public double PrecioUnitario { get; set; }

    public decimal PMonedaId { get; set; }

    public byte DldIndAfectoExento { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PDoctoLegalDetId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte TseCodigo { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;
}
