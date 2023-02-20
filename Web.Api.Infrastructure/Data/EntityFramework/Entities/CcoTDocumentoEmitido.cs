using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTDocumentoEmitido
{
    public decimal DocEmiId { get; set; }

    public decimal PSolDocId { get; set; }

    public int DocEmiSecuencia { get; set; }

    public decimal PSolDocDetId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short TdoId { get; set; }

    public int DocEmiFolio { get; set; }

    public DateTime DocEmiFecEmision { get; set; }

    public int CiuCodigo { get; set; }

    public byte DocEmiEstado { get; set; }

    public decimal PMonedaId { get; set; }

    public short DocEmiNumCuota { get; set; }

    public decimal DocEmiMontoDocumento { get; set; }

    public decimal DocEmiMontoImpuesto { get; set; }

    public decimal DocEmiPorcentaje { get; set; }

    public decimal PFolioDocId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
