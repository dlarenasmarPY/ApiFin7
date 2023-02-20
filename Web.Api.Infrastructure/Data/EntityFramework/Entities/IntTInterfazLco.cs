using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazLco
{
    public decimal IntLcoId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string IntBitArchivoLco { get; set; } = null!;

    public DateTime LlgDocFechaIng { get; set; }

    public int IntPeriodo { get; set; }

    public short OpeCod { get; set; }

    public string LlgDocGlosa { get; set; } = null!;

    public int LlgDocNumInterno { get; set; }

    public string LlgDocNumDoc { get; set; } = null!;

    public int LlgDocNumProvision { get; set; }

    public string EntRut { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public string EntRutSec { get; set; } = null!;

    public short EntSucNumeroSec { get; set; }

    public string EntRutTer { get; set; } = null!;

    public DateTime LlgDocFecha { get; set; }

    public DateTime LlgDocFechaVenc { get; set; }

    public short EntSucNumeroTer { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal LlgDocMtoImpuAfecto { get; set; }

    public decimal LlgDocMtoImpuNeto { get; set; }

    public decimal LlgDocMtoImpuExento { get; set; }

    public decimal LlgDocMtoImpuIva { get; set; }

    public decimal LlgDocMtoImpuOtrosImp { get; set; }

    public decimal LlgDocMtoImpuDerAdu { get; set; }

    public decimal LlgDocMtoImpuRete { get; set; }

    public decimal LlgDocMtoImpuTotal { get; set; }

    public decimal LlgDocMtoLocalAfecto { get; set; }

    public decimal LlgDocMtoLocalNeto { get; set; }

    public decimal LlgDocMtoLocalExento { get; set; }

    public decimal LlgDocMtoLocalIva { get; set; }

    public decimal LlgDocMtoLocalOtrosImp { get; set; }

    public decimal LlgDocMtoLocalDerAdu { get; set; }

    public decimal LlgDocMtoLocalRete { get; set; }

    public decimal LlgDocMtoLocalTotal { get; set; }

    public string DocCceDocRef { get; set; } = null!;

    public byte IntError { get; set; }

    public decimal LlgDocMtoIvaRec100 { get; set; }

    public decimal LlgDocMtoIvaRecPro { get; set; }

    public decimal LlgDocMtoIvaNoRec { get; set; }

    public byte ClaIvaId { get; set; }

    public decimal LlgDocMtoConvAfecto { get; set; }

    public decimal LlgDocMtoConvNeto { get; set; }

    public decimal LlgDocMtoConvExento { get; set; }

    public decimal LlgDocMtoConvIva { get; set; }

    public decimal LlgDocMtoConvOtrosImp { get; set; }

    public decimal LlgDocMtoConvDerAdu { get; set; }

    public decimal LlgDocMtoConvRete { get; set; }

    public decimal LlgDocMtoConvTotal { get; set; }
}
