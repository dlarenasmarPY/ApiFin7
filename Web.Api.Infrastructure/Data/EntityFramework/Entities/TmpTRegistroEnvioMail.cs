using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRegistroEnvioMail
{
    public decimal PRecepcionDetId { get; set; }

    public DateTime FechaMail { get; set; }

    public byte IndMailEnviado { get; set; }

    public byte IndEstadoCritico { get; set; }
}
