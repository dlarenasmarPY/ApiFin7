using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTTipoOperacion
{
    public decimal TipoOpeId { get; set; }

    public decimal PEmpId { get; set; }

    public short OpeCod { get; set; }

    public string OpeGlosa { get; set; } = null!;

    public short ProNegocioCod { get; set; }

    public decimal PCorId { get; set; }

    public short TcoId { get; set; }

    public byte TcoTipoFuncion { get; set; }

    public DateTime OpeFecVigencia { get; set; }

    public byte MovOriSistema { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte EscenarioCod { get; set; }

    public byte OpeTraspasa { get; set; }

    public virtual ICollection<ConTCabeceraOpe> ConTCabeceraOpes { get; } = new List<ConTCabeceraOpe>();

    public virtual ICollection<LogTTipoOpeEntidad> LogTTipoOpeEntidads { get; } = new List<LogTTipoOpeEntidad>();

    public virtual ICollection<TesTCabeceraEmi> TesTCabeceraEmis { get; } = new List<TesTCabeceraEmi>();
}
