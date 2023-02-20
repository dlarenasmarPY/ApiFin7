using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTBitacora
{
    public decimal BitId { get; set; }

    public decimal PEmpId { get; set; }

    public string BitFicArchivo { get; set; } = null!;

    public DateTime BitFicFecha { get; set; }

    public decimal PEntId { get; set; }

    public byte BitFicEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CcpTBitacoraDet> CcpTBitacoraDets { get; } = new List<CcpTBitacoraDet>();
}
