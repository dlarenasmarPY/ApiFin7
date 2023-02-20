using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegMovAbono
{
    public decimal FlegMabId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime FlegMabPerInicio { get; set; }

    public DateTime FlegMabPerTermino { get; set; }

    public double FlegMabDiasDer { get; set; }

    public double FlegMabDiasPro { get; set; }

    public double FlegMabDiasAdi { get; set; }

    public double FlegMabDiasSal { get; set; }

    public decimal FlegMabEstado { get; set; }

    public decimal PFlegBitId { get; set; }

    public decimal PFlegDatId { get; set; }

    public decimal PFlegMprId { get; set; }

    public byte FlegMprDias { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTFlegBitacora PFlegBit { get; set; } = null!;

    public virtual ICollection<RhuTFlegMovPeriodo> RhuTFlegMovPeriodos { get; } = new List<RhuTFlegMovPeriodo>();

    public virtual ICollection<RhuTFlegMovProgresivo> RhuTFlegMovProgresivos { get; } = new List<RhuTFlegMovProgresivo>();
}
