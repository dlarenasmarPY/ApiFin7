using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTLogCambioTraspasoCo
{
    public decimal PCartaOfertaId { get; set; }

    public DateTime FechaLog { get; set; }

    public string GlosaEvento { get; set; } = null!;

    public decimal OpeIdAnt { get; set; }

    public decimal OpeIdNuevo { get; set; }

    public int NroGiantiguo { get; set; }

    public int NroGinuevo { get; set; }

    public decimal CartaOfeIdNew { get; set; }

    public string RutAntiguo { get; set; } = null!;

    public string RutNuevo { get; set; } = null!;

    public string UsuarioResp { get; set; } = null!;
}
