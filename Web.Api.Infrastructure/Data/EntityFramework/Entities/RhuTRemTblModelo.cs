using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemTblModelo
{
    public decimal RemTbMid { get; set; }

    public string TbMnombre { get; set; } = null!;

    public string TbMdescripcion { get; set; } = null!;

    public short TbMtipoUso { get; set; }

    public string CnRtipoVariable { get; set; } = null!;

    public byte TbMindUsoOrigen { get; set; }

    public byte TbMindUsoDestino { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTRemConceptosPer> RhuTRemConceptosPers { get; } = new List<RhuTRemConceptosPer>();

    public virtual ICollection<RhuTRemTblAtribModelo> RhuTRemTblAtribModelos { get; } = new List<RhuTRemTblAtribModelo>();
}
