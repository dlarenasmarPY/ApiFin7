using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoNominasCfdet
{
    public decimal NomGfaDetId { get; set; }

    public decimal PNomGfaId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PGfaEntId { get; set; }

    public decimal PItmParentescoId { get; set; }

    public DateTime NomGfaFecNacimiento { get; set; }

    public decimal PItmSexoId { get; set; }

    public decimal PItmNivEducId { get; set; }

    public string NomGfaActividadLaboral { get; set; } = null!;

    public decimal PItmTipCargaId { get; set; }

    public DateTime NomGfaFecInicio { get; set; }

    public DateTime NomGfaFecTermino { get; set; }

    public DateTime NomGfaFecVigencia { get; set; }

    public DateTime NomGfaFecEmision { get; set; }

    public decimal PGfaEmpAutEntId { get; set; }

    public decimal PItmNomGfaEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParItem PItmNomGfaEstadoNavigation { get; set; } = null!;

    public virtual RhuTParItem PItmParentesco { get; set; } = null!;

    public virtual RhuTParItem PItmSexo { get; set; } = null!;

    public virtual RhuTParItem PItmTipCarga { get; set; } = null!;

    public virtual RhuTCtoNominasCf PNomGfa { get; set; } = null!;
}
