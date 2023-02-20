using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosClasificacion
{
    public decimal ProdClasId { get; set; }

    public string ProdClasDes { get; set; } = null!;

    public byte ProdClasCantNivel { get; set; }

    public string ProdClasNivel1Des { get; set; } = null!;

    public short ProdClasNivel1Largo { get; set; }

    public string ProdClasNivel2Des { get; set; } = null!;

    public short ProdClasNivel2Largo { get; set; }

    public string ProdClasNivel3Des { get; set; } = null!;

    public short ProdClasNivel3Largo { get; set; }

    public string ProdClasNivel4Des { get; set; } = null!;

    public short ProdClasNivel4Largo { get; set; }

    public string ProdClasNivel5Des { get; set; } = null!;

    public short ProdClasNivel5Largo { get; set; }

    public string ProdClasNivel6Des { get; set; } = null!;

    public short ProdClasNivel6Largo { get; set; }

    public string ProdClasNivel7Des { get; set; } = null!;

    public short ProdClasNivel7Largo { get; set; }

    public string ExiOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
