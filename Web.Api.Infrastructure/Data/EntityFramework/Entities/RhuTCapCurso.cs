using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapCurso
{
    public decimal CapCurId { get; set; }

    public decimal CapCodCur { get; set; }

    public decimal PCapTipCurId { get; set; }

    public string CapNomCur { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public decimal CapMtoRefCur { get; set; }

    public decimal CapMtoRefParCur { get; set; }

    public string CapContenido { get; set; } = null!;

    public string CapObjetivo { get; set; } = null!;

    public string CapTemario { get; set; } = null!;

    public string CapRequisitos { get; set; } = null!;

    public double CapDurHrs { get; set; }

    public short CapDurDia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapParTpCurso PCapTipCur { get; set; } = null!;

    public virtual ICollection<RhuTCapCursosEnt> RhuTCapCursosEnts { get; } = new List<RhuTCapCursosEnt>();

    public virtual ICollection<RhuTCapMallaCur> RhuTCapMallaCurs { get; } = new List<RhuTCapMallaCur>();

    public virtual ICollection<RhuTCapPostulantesDet> RhuTCapPostulantesDets { get; } = new List<RhuTCapPostulantesDet>();
}
