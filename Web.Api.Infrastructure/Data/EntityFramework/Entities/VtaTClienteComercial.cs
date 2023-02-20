using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTClienteComercial
{
    public decimal PEntId { get; set; }

    public decimal PEmpId { get; set; }

    public byte NivelLpr { get; set; }

    public decimal PListaPreCabId { get; set; }

    public byte CliRevisaOrdenC { get; set; }

    public byte TipoCliente { get; set; }

    public string CliTipoAjusteFec { get; set; } = null!;

    public string CliDiaSemana { get; set; } = null!;

    public string CliOrdenDia { get; set; } = null!;

    public byte NivelVendedor { get; set; }

    public decimal PVendedorId { get; set; }

    public short CliIndDespachoParcial { get; set; }

    public decimal CliPorcDespacho { get; set; }

    public byte CliIndConvDevol { get; set; }

    public decimal CliPorcDevol { get; set; }

    public string CliFrecuenciaDevol { get; set; } = null!;

    public string CliComentarioConvDevol { get; set; } = null!;

    public DateTime CliVigenciaConvDevol { get; set; }

    public byte IndRetencion { get; set; }

    public byte ImportaciaCli { get; set; }

    public decimal PIdiomaEspId { get; set; }

    public byte CliIndNivel { get; set; }

    public byte CliNoImprime { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string CliObsDocumento { get; set; } = null!;

    public string CliObsGenerica { get; set; } = null!;
}
