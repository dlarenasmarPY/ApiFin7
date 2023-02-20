using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTEstructuraCodigo
{
    public decimal EstCodigoId { get; set; }

    public string EstCodigoCod { get; set; } = null!;

    public string EstCodigoDes { get; set; } = null!;

    public byte EstCodigoLargo { get; set; }

    public byte EstCodigoNumSubdiv { get; set; }

    public decimal PTipoCodigoId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<ExiTEstructuraSubdivision> ExiTEstructuraSubdivisions { get; } = new List<ExiTEstructuraSubdivision>();

    public virtual ICollection<ExiTProductosCodigo> ExiTProductosCodigos { get; } = new List<ExiTProductosCodigo>();
}
