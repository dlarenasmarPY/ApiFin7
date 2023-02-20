using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTPerSolicitud
{
    public decimal SpeId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PTexId { get; set; }

    public DateTime SpeFecInicio { get; set; }

    public DateTime SpeFecTermino { get; set; }

    public short SpeDias { get; set; }

    public DateTime SpeHraInicio { get; set; }

    public DateTime SpeHraTermino { get; set; }

    public double SpeHoras { get; set; }

    public DateTime SpeFecSolic { get; set; }

    public string SpeObsSolic { get; set; } = null!;

    public DateTime SpeFecResol { get; set; }

    public string SpeObsResol { get; set; } = null!;

    public decimal PItmEstSpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual RhuTParItem PItmEstSpe { get; set; } = null!;

    public virtual RhuTExcTipExc PTex { get; set; } = null!;
}
