using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemConceptosMe
{
    public decimal ConcMesId { get; set; }

    public decimal PConcRemId { get; set; }

    public DateTime CnMfecVigencia { get; set; }

    public double CnMvalor { get; set; }

    public short CnMhora { get; set; }

    public DateTime CnMfecha { get; set; }

    public string CnMstring { get; set; } = null!;

    public DateTime CnMfecIniAsistencia { get; set; }

    public DateTime CnMfecTerAsistencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;
}
