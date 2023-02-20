using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTPromesasImpresa
{
    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public byte TipoPromesa { get; set; }

    public decimal PCartaOfertaId { get; set; }

    public int NumeroPromesa { get; set; }

    public string RutCartaOferta { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public string RutTitular2 { get; set; } = null!;

    public string EntRazonSocial2 { get; set; } = null!;

    public string RutTitularRepLeg { get; set; } = null!;

    public string EntRazonSocial3 { get; set; } = null!;

    public DateTime FechaEmision { get; set; }

    public byte Estado { get; set; }

    public DateTime FechaEstado { get; set; }

    public string Usuario { get; set; } = null!;

    public string DireccionTitular { get; set; } = null!;

    public string DireccEmpresaComp { get; set; } = null!;

    public int CarOfeNumInterno { get; set; }

    public int CodEstadoDoc { get; set; }
}
