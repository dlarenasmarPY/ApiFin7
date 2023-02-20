using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapCursosEnt
{
    public decimal CapCurEntId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PCapCurId { get; set; }

    public DateTime CapCurEntFecVig { get; set; }

    public DateTime CapCurEntFecVigTer { get; set; }

    public string CapCurEntNom { get; set; } = null!;

    public decimal CapCurEntCod { get; set; }

    public byte CapCurEntSence { get; set; }

    public decimal CapCurEntCodSence { get; set; }

    public short CapCurEntDurDia { get; set; }

    public double CapCurEntDurHrs { get; set; }

    public decimal PCapTipEvalId { get; set; }

    public decimal PCapNotasId { get; set; }

    public short CapCurEntMinAsi { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCurso PCapCur { get; set; } = null!;

    public virtual RhuTCapParNota PCapNotas { get; set; } = null!;

    public virtual RhuTCapParTipEval PCapTipEval { get; set; } = null!;

    public virtual RhuTCapEntidade PEnt { get; set; } = null!;

    public virtual ICollection<RhuTCapCursosCalen> RhuTCapCursosCalens { get; } = new List<RhuTCapCursosCalen>();

    public virtual ICollection<RhuTCapCursosPrecio> RhuTCapCursosPrecios { get; } = new List<RhuTCapCursosPrecio>();

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucions { get; } = new List<RhuTCapEjecucion>();

    public virtual ICollection<RhuTCapPlane> RhuTCapPlanes { get; } = new List<RhuTCapPlane>();
}
