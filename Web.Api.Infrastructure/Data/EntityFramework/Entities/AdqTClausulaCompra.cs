using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTClausulaCompra
{
    public decimal ClausulaId { get; set; }

    public string ClausulaDes { get; set; } = null!;

    public double ClausulaPorcFob { get; set; }

    public double ClausulaPorcCif { get; set; }

    public double ClausulaPorcBodega { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<AdqTClausulaCompraDocto> AdqTClausulaCompraDoctos { get; } = new List<AdqTClausulaCompraDocto>();
}
