using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CbaTCartola
{
    public decimal CabCbaId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public int CarFolio { get; set; }

    public short CarAno { get; set; }

    public DateTime CarFechaInicio { get; set; }

    public DateTime CarFechaTermino { get; set; }

    public double CarSaldoInicial { get; set; }

    public double CarSaldoFinal { get; set; }

    public byte CarEstado { get; set; }

    public string CarOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CbaTCartolasDet> CbaTCartolasDets { get; } = new List<CbaTCartolasDet>();
}
