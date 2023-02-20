using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTDoctoVentaCabExp
{
    public decimal PDoctoVentaCabId { get; set; }

    public decimal PEntNotificadorId { get; set; }

    public decimal PEntSucNotificadorId { get; set; }

    public decimal PEntDirNotificadorId { get; set; }

    public decimal PEntConNotificadorId { get; set; }

    public decimal PEntConsignatarioId { get; set; }

    public decimal PEntSucConsignatarioId { get; set; }

    public decimal PEntDirConsignatarioId { get; set; }

    public decimal PEntConConsignatarioId { get; set; }

    public decimal PClausulaVenta { get; set; }

    public decimal PIdiomaEspId { get; set; }

    public decimal PUnidadMedClienteId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public short TppCodigo { get; set; }
}
