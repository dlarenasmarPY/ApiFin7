using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBien
{
    public decimal CodigoBienId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public string AfiDescripcion { get; set; } = null!;

    public short AfiSubGrpCod { get; set; }

    public decimal AfiOpeCod { get; set; }

    public int AfiCantidad { get; set; }

    public string AfiCodAnterior { get; set; } = null!;

    public decimal AfiUbiFisicaCod { get; set; }

    public decimal PEntId { get; set; }

    public short AfiUnidadCod { get; set; }

    public byte AfiUsaCrFiscal { get; set; }

    public DateTime AfiFechaInventario { get; set; }

    public decimal PCodigoBienOri { get; set; }

    public string AfiCodBarraBien { get; set; } = null!;

    public DateTime AfiFechaIngreso { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int CdiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public string AfiOwner { get; set; } = null!;

    public byte AfiIndSecuencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PPartidaId { get; set; }
}
