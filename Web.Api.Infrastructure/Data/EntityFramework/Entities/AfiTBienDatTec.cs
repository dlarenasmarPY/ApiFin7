using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienDatTec
{
    public decimal DatTecId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public string AfiMarca { get; set; } = null!;

    public string AfiModelo { get; set; } = null!;

    public string AfiCodSerie { get; set; } = null!;

    public DateTime AfiFechaFabric { get; set; }

    public string AfiEspTecnica { get; set; } = null!;

    public string AfiCodAgrup { get; set; } = null!;

    public byte AfiEstFisico { get; set; }

    public string AfiCodBarraBien { get; set; } = null!;

    public decimal AfiUbiFisicaCod { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int CdiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PPartidaId { get; set; }
}
