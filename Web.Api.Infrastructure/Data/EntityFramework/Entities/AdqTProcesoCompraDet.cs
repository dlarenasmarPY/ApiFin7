using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTProcesoCompraDet
{
    public decimal ProCompraDetId { get; set; }

    public decimal PProCompraCabId { get; set; }

    public int NumeroReferencia { get; set; }

    public decimal PPedidoMaterialDetId { get; set; }

    public DateTime FechaRequerida { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public double CantDocOrigen { get; set; }

    public decimal PUnidadMedOrigenId { get; set; }

    public double CantidadStock { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PBodegaId { get; set; }

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual AdqTProcesoCompraCab PProCompraCab { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedOrigen { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedStock { get; set; } = null!;
}
