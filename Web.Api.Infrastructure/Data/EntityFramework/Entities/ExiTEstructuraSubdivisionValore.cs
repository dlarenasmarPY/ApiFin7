using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTEstructuraSubdivisionValore
{
    public decimal SubdivisionDetId { get; set; }

    public decimal PSubdivisionId { get; set; }

    public byte SubdivisionTipoSub { get; set; }

    public int SubdivisionDetValorMin { get; set; }

    public int SubdivisionDetValorMax { get; set; }

    public int SubdivisionDetValorInc { get; set; }

    public int SubdivisionDetValorFinal { get; set; }

    public string SubdivisionDetGlosaTabla { get; set; } = null!;

    public string SubdivisionDetValorTabla1 { get; set; } = null!;

    public decimal SubdivisionDetValorTabla2 { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ExiTEstructuraSubdivision PSubdivision { get; set; } = null!;
}
