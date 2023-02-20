using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntMedico
{
    public decimal AntMedId { get; set; }

    public decimal PFicPerId { get; set; }

    public string MedCodEnf { get; set; } = null!;

    public byte MedIndEnfProf { get; set; }

    public byte MedIndContagio { get; set; }

    public DateTime MedFecInicio { get; set; }

    public byte MedIndAlta { get; set; }

    public DateTime MedFecAlta { get; set; }

    public string MedObservacion { get; set; } = null!;

    public string MedDescripcion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;
}
