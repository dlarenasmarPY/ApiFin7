using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemAftramoCalculadoDet
{
    public decimal AftramoDetId { get; set; }

    public decimal PAftramoId { get; set; }

    public byte PerMes { get; set; }

    public double AfttramoImponMes { get; set; }

    public short AfttramoDias { get; set; }

    public double AfdecJurMonto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemAftramoCalculado PAftramo { get; set; } = null!;
}
