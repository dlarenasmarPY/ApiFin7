using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTEstrucClasific
{
    public decimal PPdAfiId { get; set; }

    public short ClaAfiNivel1 { get; set; }

    public short ClaAfiNivel2 { get; set; }

    public short ClaAfiNivel3 { get; set; }

    public short ClaAfiNivel4 { get; set; }

    public short ClaAfiNivel5 { get; set; }

    public short ClaAfiNivel6 { get; set; }

    public short ClaAfiNivel7 { get; set; }

    public byte ClaAfiNodoNivel { get; set; }

    public string ClaAfiNodoNombre { get; set; } = null!;

    public decimal PCodigoBienId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
