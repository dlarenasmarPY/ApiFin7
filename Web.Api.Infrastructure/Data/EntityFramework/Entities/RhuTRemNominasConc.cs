using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemNominasConc
{
    public decimal NomConcId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PProcRemPerId { get; set; }

    public string NcnCodOrigen { get; set; } = null!;

    public string NcnUsuOrigen { get; set; } = null!;

    public DateTime NcnFecRecep { get; set; }

    public string NcnNombre { get; set; } = null!;

    public string NcnEstadoReg { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemProcesosPer PProcRemPer { get; set; } = null!;

    public virtual ICollection<RhuTRemNominasConcDet> RhuTRemNominasConcDets { get; } = new List<RhuTRemNominasConcDet>();
}
