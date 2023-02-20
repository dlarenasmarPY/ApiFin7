using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParTabla
{
    public decimal TabParId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public string TabCodigo { get; set; } = null!;

    public string TabDescripcion { get; set; } = null!;

    public byte TabIndUso { get; set; }

    public byte TabUsoAfiliacion { get; set; }

    public byte TabUsoCalculo { get; set; }

    public byte TabUsoInterno { get; set; }

    public string TabLabelValor1 { get; set; } = null!;

    public string TabLabelValor2 { get; set; } = null!;

    public string TabLabelValor3 { get; set; } = null!;

    public string TabLabelValor4 { get; set; } = null!;

    public string TabLabelValor5 { get; set; } = null!;

    public string TabLabelValor6 { get; set; } = null!;

    public string TabLabelValor7 { get; set; } = null!;

    public string TabLabelValor8 { get; set; } = null!;

    public string TabLabelValor9 { get; set; } = null!;

    public string TabLabelValor10 { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTParInterfazDet> RhuTParInterfazDets { get; } = new List<RhuTParInterfazDet>();

    public virtual ICollection<RhuTParItem> RhuTParItems { get; } = new List<RhuTParItem>();
}
