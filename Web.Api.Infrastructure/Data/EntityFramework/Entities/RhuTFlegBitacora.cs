using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegBitacora
{
    public decimal FlegBitId { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime FlegBitFecDesde { get; set; }

    public DateTime FlegBitFecHasta { get; set; }

    public decimal FlegBitEstado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int FlegSecuencia { get; set; }

    public virtual RhuTParEmpresa PEmp { get; set; } = null!;

    public virtual ICollection<RhuTFlegMovAbono> RhuTFlegMovAbonos { get; } = new List<RhuTFlegMovAbono>();
}
