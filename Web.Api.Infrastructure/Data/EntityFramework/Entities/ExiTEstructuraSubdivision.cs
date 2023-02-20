using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTEstructuraSubdivision
{
    public decimal SubdivisionId { get; set; }

    public decimal PEstCodigoId { get; set; }

    public byte SubdivisionSecuencia { get; set; }

    public string SubdivisionDes { get; set; } = null!;

    public byte SubdivisionTipoSub { get; set; }

    public byte SubdivisionTipoDatos { get; set; }

    public byte SubdivisionLargo { get; set; }

    public byte SubdivisionUsaSeparador { get; set; }

    public byte SubdivisionTipoSeparador { get; set; }

    public byte SubdivisionPosicion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<ExiTEstructuraSubdivisionValore> ExiTEstructuraSubdivisionValores { get; } = new List<ExiTEstructuraSubdivisionValore>();

    public virtual ExiTEstructuraCodigo PEstCodigo { get; set; } = null!;
}
