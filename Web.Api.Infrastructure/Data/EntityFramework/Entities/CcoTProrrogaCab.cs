using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTProrrogaCab
{
    public decimal ProrrogaId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PEntId { get; set; }

    public double ProrrogaTasa { get; set; }

    public byte ProIndInteres { get; set; }

    public byte ProIndInteresDoc { get; set; }

    public byte ProIndInteresMes { get; set; }

    public DateTime ProCabFecProrroga { get; set; }

    public decimal PTipoOpeId { get; set; }

    public byte ProCabEstProrroga { get; set; }

    public string ProCabGlosaProrroga { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public string ProCabDigUsuario { get; set; } = null!;

    public DateTime ProCabDigFec { get; set; }

    public string ProCabAprUsuario { get; set; } = null!;

    public DateTime ProCabAprFec { get; set; }

    public DateTime ProCabRevFec { get; set; }

    public string ProCabRevUsuario { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
