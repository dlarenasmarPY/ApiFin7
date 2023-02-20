using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoNegocio
{
    public decimal NegocioVtaId { get; set; }

    public string NegocioVtaGlosa { get; set; } = null!;

    public byte TngCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public byte FormaAtencionCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte NgvModalidadVta { get; set; }

    public byte NgvIndFacturable { get; set; }

    public byte NgvIndBloqueaCcosto { get; set; }

    public byte NgvIndExento { get; set; }

    public byte NgvIndVisaObligatoria { get; set; }

    public decimal PCreId { get; set; }

    public decimal NgvContraCtaFactura { get; set; }

    public decimal NgvContraCtaGuia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public byte NgvIndDiferido { get; set; }

    public byte TdfCodigo { get; set; }
}
