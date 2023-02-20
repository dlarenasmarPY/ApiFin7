using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFicAntGrupoFamiliarOld
{
    public decimal AntGruFamId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PGfaEntId { get; set; }

    public decimal PItmParentescoId { get; set; }

    public DateTime GfaFecNacimiento { get; set; }

    public decimal PItmSexoId { get; set; }

    public decimal PItmNivEducId { get; set; }

    public string GfaActividadLaboral { get; set; } = null!;

    public decimal PItmTipCargaId { get; set; }

    public decimal PItmTipCargaAdiId { get; set; }

    public DateTime GfaFecInicio { get; set; }

    public DateTime GfaFecTermino { get; set; }

    public DateTime GfaFecVigencia { get; set; }

    public DateTime GfaFecEmision { get; set; }

    public decimal PGfaEmpAutEntId { get; set; }

    public decimal PNomGfaDetId { get; set; }

    public byte GfaEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal GfaNroResolucion { get; set; }
}
