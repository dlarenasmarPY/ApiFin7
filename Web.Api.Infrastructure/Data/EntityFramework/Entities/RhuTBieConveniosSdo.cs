using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieConveniosSdo
{
    public decimal BieConvSdoId { get; set; }

    public decimal PBieConvId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PNomConcDetId { get; set; }

    public DateTime FecProceso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTBieConvenio PBieConv { get; set; } = null!;
}
