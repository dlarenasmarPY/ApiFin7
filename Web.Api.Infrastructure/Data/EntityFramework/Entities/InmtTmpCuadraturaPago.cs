using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmtTmpCuadraturaPago
{
    public int PEmpid { get; set; }

    public int CabOpeNumero { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public int PCartaOfertaId { get; set; }

    public int CarOfenumInterno { get; set; }

    public short ItemFinId { get; set; }

    public decimal MontoRecibidoFicoDebe { get; set; }

    public decimal MontoRecibidoFicoHaber { get; set; }

    public decimal MontoRecibidoGi { get; set; }
}
