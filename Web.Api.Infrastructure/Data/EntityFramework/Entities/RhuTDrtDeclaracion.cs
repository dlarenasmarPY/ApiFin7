using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTDrtDeclaracion
{
    public decimal DrtDclId { get; set; }

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public decimal DrtFolio { get; set; }

    public decimal DrtFolioAnt { get; set; }

    public decimal DrtCertificadoIni { get; set; }

    public string DrtEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTDrtResumenAnual> RhuTDrtResumenAnuals { get; } = new List<RhuTDrtResumenAnual>();

    public virtual ICollection<RhuTDrtResumenMen> RhuTDrtResumenMen { get; } = new List<RhuTDrtResumenMen>();
}
