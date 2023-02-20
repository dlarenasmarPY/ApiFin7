using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRecepcionDocCab
{
    public decimal RecDocCabId { get; set; }

    public byte TipNomCod { get; set; }

    public int RecDocCabNumNomina { get; set; }

    public DateTime RecDocCabFecNomina { get; set; }

    public byte RecDocCabEstado { get; set; }

    public DateTime RecDocCabFecEstado { get; set; }

    public short PerId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PEntCcoId { get; set; }

    public string RecDocCabNumCedente { get; set; } = null!;

    public DateTime RecDocCabFecCedente { get; set; }

    public byte ModCcoCod { get; set; }

    public byte InsCcoCod { get; set; }

    public short TdoAgrupaCod { get; set; }

    public decimal PMonedaId { get; set; }

    public int InstCod { get; set; }

    public int PlaCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte TipNotCod { get; set; }

    public string RecDocCabNumContrato { get; set; } = null!;

    public double RecDocCabMontoAnticipo { get; set; }

    public double RecDocCabMontoGasto { get; set; }

    public double RecDocCabMontoInteres { get; set; }

    public double RecDocCabPorcentajeFin { get; set; }

    public string RecDocCabOwner { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public DateTime RecDocCabFechaReversa { get; set; }

    public string RecDocCabNomArchivo { get; set; } = null!;

    public DateTime RecDocCabFechaRecepcion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
