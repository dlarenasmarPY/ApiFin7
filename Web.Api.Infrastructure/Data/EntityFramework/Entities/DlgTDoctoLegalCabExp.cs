using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalCabExp
{
    public decimal PDoctoLegalCabId { get; set; }

    public double DlcKiloNeto { get; set; }

    public double DlcKiloBruto { get; set; }

    public decimal PFormaPagoId { get; set; }

    public short TppCodigo { get; set; }

    public byte CocUsaPrecioFob { get; set; }

    public byte EmcUsaMtoEscrito { get; set; }

    public byte EmcUsaKiloNeto { get; set; }

    public byte EmcUsaCantItem { get; set; }

    public byte EmcUsaAgrupaDetalle { get; set; }

    public byte EmcUsaObsPiePagina { get; set; }

    public string EmcObsPiePagina { get; set; } = null!;

    public string DlcNumInforme { get; set; } = null!;

    public string DlcNumLc { get; set; } = null!;

    public decimal PEntNotificadorId { get; set; }

    public string DlcDirNotificador { get; set; } = null!;

    public decimal PEntConsignatarioId { get; set; }

    public string DlcDirConsignatario { get; set; } = null!;

    public string DlcObsBulto { get; set; } = null!;

    public string DlcObsMercaderia { get; set; } = null!;

    public string CliObsGenerica { get; set; } = null!;

    public string CliObsDocumento { get; set; } = null!;

    public string DlcLugarDestino { get; set; } = null!;

    public string EntDirDireccionLarga { get; set; } = null!;

    public string DlcRefPacking { get; set; } = null!;

    public string DlcObsPacking { get; set; } = null!;

    public string DlcFclPacking { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
