using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTCentroConsumo
{
    public decimal CconsumoId { get; set; }

    public int CconsumoCod { get; set; }

    public string CconsumoDes { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PEntDirId { get; set; }

    public decimal PPlantaId { get; set; }

    public string EntRutResponsable { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PEntSucIdAuxiliar { get; set; }

    public virtual ExiTPlanta PPlanta { get; set; } = null!;
}
