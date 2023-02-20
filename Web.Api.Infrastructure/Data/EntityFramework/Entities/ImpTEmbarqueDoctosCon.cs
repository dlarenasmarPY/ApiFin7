using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueDoctosCon
{
    public decimal EmbarqueDocConId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public byte EmcTipoTransporte { get; set; }

    public byte TipoTranspCod { get; set; }

    public string EmcNave { get; set; } = null!;

    public string EmbViaje { get; set; } = null!;

    public decimal PPuertoOrigen { get; set; }

    public decimal PPuertoDestino { get; set; }

    public decimal PTipoPackingId { get; set; }

    public short NroBultos { get; set; }

    public decimal Volumen { get; set; }

    public double EmbKilos { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
