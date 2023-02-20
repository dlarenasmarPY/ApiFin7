using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemAftramoCalculado
{
    public decimal AftramoId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte AftramoTipCto { get; set; }

    public decimal PTramoId { get; set; }

    public double LqTtimponibleProm { get; set; }

    public decimal PTramoIdNew { get; set; }

    public string AftramoEst { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PAntPrevId { get; set; }

    public virtual ICollection<RhuTRemAftramoCalculadoDet> RhuTRemAftramoCalculadoDets { get; } = new List<RhuTRemAftramoCalculadoDet>();
}
