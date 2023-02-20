﻿using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTClienteSucursal
{
    public decimal PEntSucId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public double CliMtoLineaCredito { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PVendedorId { get; set; }

    public decimal PListaPreCabId { get; set; }

    public decimal PEntSucCompraId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string CliSucReferencia { get; set; } = null!;
}
