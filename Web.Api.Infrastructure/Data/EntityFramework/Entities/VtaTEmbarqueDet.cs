using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTEmbarqueDet
{
    public decimal EmbarqueDetId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public short TdoId { get; set; }

    public string EmdFolioDocto { get; set; } = null!;

    public DateTime EmdFecDocto { get; set; }

    public string EmdEmisorDocto { get; set; } = null!;

    public double EmdMtoDocto { get; set; }

    public decimal PMonedaId { get; set; }

    public string EmdRutaDocto { get; set; } = null!;

    public string EmdArchivoDocto { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
