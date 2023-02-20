using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTReposicion
{
    public decimal PEmpId { get; set; }

    public decimal POcCabId { get; set; }

    public decimal PPuntoReordenId { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte IndTipoReposicion { get; set; }

    public byte IndTipoTransito { get; set; }

    public decimal NivArtMaximo { get; set; }

    public decimal NivArtMinimo { get; set; }

    public decimal NivArtCritico { get; set; }

    public byte NivArtNumPer { get; set; }

    public string GrpConsCod { get; set; } = null!;

    public string GrpCompCod { get; set; } = null!;

    public DateTime FechaUltRevision { get; set; }

    public byte DiasParaRevision { get; set; }

    public DateTime FechaProxRevision { get; set; }

    public short DiasDemoraEntrega { get; set; }

    public decimal CantReqTotal { get; set; }

    public decimal CantPropTotal { get; set; }

    public decimal PrecioReq { get; set; }

    public decimal PrecioUltCompra { get; set; }

    public double IndCobTotal { get; set; }

    public double IndCobFisico { get; set; }

    public decimal StockTransTotal { get; set; }

    public decimal StockActual { get; set; }

    public double EstConsPromMensual { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal? PEntId { get; set; }

    public byte? IndRut { get; set; }
}
