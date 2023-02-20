using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTSolicitudEmiDocDet
{
    public decimal SolDocDetId { get; set; }

    public decimal PSolDocId { get; set; }

    public int SolDocDetSecuencia { get; set; }

    public decimal PRenCuoId { get; set; }

    public short SolDocDetNumCuota { get; set; }

    public DateTime SolDocDetFecVenc { get; set; }

    public decimal SolDocDetMontoDocumento { get; set; }

    public byte SolDocDetEstado { get; set; }

    public DateTime SolDocDetFecEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
