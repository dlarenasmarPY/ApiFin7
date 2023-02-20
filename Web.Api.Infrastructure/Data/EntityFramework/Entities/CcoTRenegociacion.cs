using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRenegociacion
{
    public decimal RenCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public byte TipNomCod { get; set; }

    public int RenCabNumRenegociacion { get; set; }

    public DateTime RenCabFecRenegociacion { get; set; }

    public byte RenCabEstado { get; set; }

    public DateTime RenCabFecEstado { get; set; }

    public short TdoId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PMonedaId { get; set; }

    public double TasaConvenio { get; set; }

    public short CuotasConvenio { get; set; }

    public DateTime RenCabFecVenReneg { get; set; }

    public short RenCabPeriodicidad { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal RenCabPorcenImpto { get; set; }

    public byte IndGastos { get; set; }

    public byte IndInteres { get; set; }

    public double RenCabMontoInteres { get; set; }

    public string RenCabOwner { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public DateTime RenCabFechaReversa { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
