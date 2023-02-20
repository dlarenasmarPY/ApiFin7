using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTPerRsolicitud
{
    public decimal PSpeId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PTexId { get; set; }

    public DateTime SpeRfecInicio { get; set; }

    public DateTime SpeRfecTermino { get; set; }

    public short SpeRdias { get; set; }

    public DateTime SpeRhraInicio { get; set; }

    public DateTime SpeRhraTermino { get; set; }

    public double SpeRhoras { get; set; }

    public DateTime SpeRfecSolic { get; set; }

    public string SpeRobsSolic { get; set; } = null!;

    public DateTime SpeRfecResol { get; set; }

    public string SpeRobsResol { get; set; } = null!;

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
