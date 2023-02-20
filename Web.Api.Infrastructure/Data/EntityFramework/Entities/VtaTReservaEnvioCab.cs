using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTReservaEnvioCab
{
    public decimal ReservaEnvioCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string RecNumReserva { get; set; } = null!;

    public decimal PEntCiaTransId { get; set; }

    public decimal PEntSucCiaTransId { get; set; }

    public decimal PTransporteId { get; set; }

    public DateTime RecFecReserva { get; set; }

    public DateTime RecFecSalida { get; set; }

    public DateTime RecFecStacking { get; set; }

    public DateTime RecFecArribo { get; set; }

    public decimal PPuertoOrigen { get; set; }

    public decimal PPuertoDestino { get; set; }

    public double RecCantContenedor { get; set; }

    public byte ConEstCod { get; set; }

    public string RecEspacioReservado { get; set; } = null!;

    public string RecGlosa { get; set; } = null!;

    public string CodOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
