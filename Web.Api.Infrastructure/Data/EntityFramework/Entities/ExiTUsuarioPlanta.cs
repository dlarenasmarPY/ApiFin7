using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTUsuarioPlanta
{
    public string FldUserCode { get; set; } = null!;

    public decimal PPlantaId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public byte IndAjustaConf { get; set; }
}
