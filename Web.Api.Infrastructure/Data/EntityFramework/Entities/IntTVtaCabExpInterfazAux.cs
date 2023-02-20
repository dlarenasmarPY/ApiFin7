using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTVtaCabExpInterfazAux
{
    public string IntTmpOwner { get; set; } = null!;

    public decimal PDoctoVentaCabId { get; set; }

    public string EntRutNotificador { get; set; } = null!;

    public short EntSucNotificador { get; set; }

    public string DireccionNotificador { get; set; } = null!;

    public string ContactoNotificador { get; set; } = null!;

    public string RutConsignatario { get; set; } = null!;

    public short EntSucConsignatario { get; set; }

    public string DireccionConsignatario { get; set; } = null!;

    public string ContactoConsignatario { get; set; } = null!;

    public decimal PClausulaVenta { get; set; }

    public decimal PIdiomaEspId { get; set; }

    public decimal PUnidadMedClienteId { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public string IntBitArchivo { get; set; } = null!;

    public int CabOpeLinea { get; set; }
}
