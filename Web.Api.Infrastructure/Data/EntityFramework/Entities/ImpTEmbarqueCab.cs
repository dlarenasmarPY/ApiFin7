using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueCab
{
    public decimal EmbarqueCabId { get; set; }

    public int CarpetaImpCod { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal MatrizCod { get; set; }

    public decimal PPuertoOrigen { get; set; }

    public decimal PPuertoDestino { get; set; }

    public byte TipoTranspCod { get; set; }

    public DateTime FechaApertura { get; set; }

    public DateTime FechaEmbarque { get; set; }

    public DateTime FechaProceso { get; set; }

    public string Observacion { get; set; } = null!;

    public string CodOwner { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public double EmbCosDirCont { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int IntegradoWms { get; set; }

    public decimal PPaisId { get; set; }
}
