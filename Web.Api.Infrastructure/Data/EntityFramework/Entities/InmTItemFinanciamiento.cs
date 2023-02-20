using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTItemFinanciamiento
{
    public short ItemFinId { get; set; }

    public string ItemFinGlosa { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public short TdoId { get; set; }

    public byte IndDesglose { get; set; }

    public byte ItemGenId { get; set; }

    public double Porcentaje { get; set; }

    public byte IndConformaPventa { get; set; }

    public decimal PMonedaId { get; set; }

    public double Monto { get; set; }

    public byte IndEmpId { get; set; }

    public double PorcDescto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<InmTCarOfeItemFinan> InmTCarOfeItemFinans { get; } = new List<InmTCarOfeItemFinan>();

    public virtual ICollection<InmTTipoVentum> Tventa { get; } = new List<InmTTipoVentum>();
}
