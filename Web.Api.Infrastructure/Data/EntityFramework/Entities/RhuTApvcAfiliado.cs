using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTApvcAfiliado
{
    public decimal ApvcAfId { get; set; }

    public decimal PCtoApvcId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime ApvcAfFecSuscripcion { get; set; }

    public DateTime ApvcAfFecInicio { get; set; }

    public DateTime ApvcAfFecTermino { get; set; }

    public short ApvcAfPeriodicidad { get; set; }

    public short ApvcAfPlazo { get; set; }

    public decimal PMonedaAhId { get; set; }

    public double ApvcAfValor { get; set; }

    public decimal ApvcAfRegTributario { get; set; }

    public decimal PItmFpagoAfId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem ApvcAfRegTributarioNavigation { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTApvcEmpresa PCtoApvc { get; set; } = null!;

    public virtual RhuTParItem PItmFpagoAf { get; set; } = null!;

    public virtual RhuTParMoneda PMonedaAh { get; set; } = null!;
}
