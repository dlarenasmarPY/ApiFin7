using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTDocumentosSistema
{
    public decimal DocSisId { get; set; }

    public byte SisCodOri { get; set; }

    public short TdoId { get; set; }

    public byte DocSisTipoMov { get; set; }

    public DateTime DocSisFecVigencia { get; set; }

    public short LblCod { get; set; }

    public short UblId { get; set; }

    public int DocSisDiasAtraso { get; set; }

    public byte DocSisDirector { get; set; }

    public short DocSisDiasCaducidad { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short TdoIdAnula { get; set; }

    public short TipoDoctoSii { get; set; }
}
