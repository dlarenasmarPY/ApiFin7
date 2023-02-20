using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosClasificacionNivel
{
    public decimal ProdClasNivelNodoId { get; set; }

    public string ProdClasNivelNodoDes { get; set; } = null!;

    public decimal PProdClasId { get; set; }

    public byte ProdClasNivelNodo { get; set; }

    public short ProdClasNivel1Nodo { get; set; }

    public short ProdClasNivel2Nodo { get; set; }

    public short ProdClasNivel3Nodo { get; set; }

    public short ProdClasNivel4Nodo { get; set; }

    public short ProdClasNivel5Nodo { get; set; }

    public short ProdClasNivel6Nodo { get; set; }

    public short ProdClasNivel7Nodo { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public string ProdClasNodoCodigoAlt { get; set; } = null!;
}
