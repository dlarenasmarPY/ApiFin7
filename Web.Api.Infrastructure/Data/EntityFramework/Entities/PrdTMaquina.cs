using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTMaquina
{
    public decimal MaquinaId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PSeccionId { get; set; }

    public string MaquinaDes { get; set; } = null!;

    public string MaquinaCod { get; set; } = null!;

    public decimal PRegimenId { get; set; }

    public int MaquinaSetup { get; set; }

    public decimal MaquinaVel { get; set; }

    public decimal PUnidadRendimientoId { get; set; }

    public decimal PActividadId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
