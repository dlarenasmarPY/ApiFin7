using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTPlantillasDocumento
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PTprId { get; set; }

    public int DocumentoId { get; set; }

    public string NombreDocumento { get; set; } = null!;

    public string Objetivo { get; set; } = null!;

    public int CodTipoDocumento { get; set; }

    public string DocumentoHtml { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }

    public string Usuario { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public byte IndVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
