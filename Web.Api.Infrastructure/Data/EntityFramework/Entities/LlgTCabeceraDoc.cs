using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTCabeceraDoc
{
    public decimal CabLlgId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public int LlgDocNumInterno { get; set; }

    public string LlgDocNumDoc { get; set; } = null!;

    public DateTime LlgDocFechaIng { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public int LlgDocNumProvision { get; set; }

    public DateTime LlgDocFecha { get; set; }

    public DateTime LlgDocFechaVenc { get; set; }

    public byte LlgDocEstado { get; set; }

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

    public decimal LlgDocMtoTotalNeto { get; set; }

    public decimal LlgDocMtoIvaRec100 { get; set; }

    public decimal LlgDocMtoIvaRecPro { get; set; }

    public decimal LlgDocMtoIvaNoRec { get; set; }

    public DateTime LlgDocFechaReversa { get; set; }

    public decimal LlgIdReversa { get; set; }

    public string LlgDocDigUsuario { get; set; } = null!;

    public DateTime LlgDocDigFecha { get; set; }

    public string LlgDocActUsuario { get; set; } = null!;

    public DateTime LlgDocActFecha { get; set; }

    public string LlgDocAprUsuario { get; set; } = null!;

    public DateTime LlgDocAprFecha { get; set; }

    public string LlgDocOwner { get; set; } = null!;

    public string LlgDocGlosa { get; set; } = null!;

    public byte ClaIvaId { get; set; }

    public byte TipFactId { get; set; }

    public int CobId { get; set; }

    public int VenId { get; set; }

    public byte OrigenArticulo { get; set; }

    public short TipOriDoctoCod { get; set; }

    public byte DlcEstadoDte { get; set; }

    public short DteId { get; set; }

    public byte LibTipo { get; set; }

    public int LibNumero { get; set; }

    public string TipoEnvio { get; set; } = null!;

    public string FelError { get; set; } = null!;

    public string FelTipo { get; set; } = null!;

    public short TcoId { get; set; }

    public decimal PCabCompId { get; set; }

    public byte InterEmpDiv { get; set; }

    public byte SisCodOri { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal LlgDocMtoConvAfecto { get; set; }

    public decimal LlgDocMtoConvNeto { get; set; }

    public decimal LlgDocMtoConvExento { get; set; }

    public decimal LlgDocMtoConvIva { get; set; }

    public decimal LlgDocMtoConvOtrosImp { get; set; }

    public decimal LlgDocMtoConvDerAdu { get; set; }

    public decimal LlgDocMtoConvRete { get; set; }

    public decimal LlgDocMtoConvTotal { get; set; }

    public decimal PLibId { get; set; }

    public decimal LlgDocMtoIvaLocalRec100 { get; set; }

    public decimal LlgDocMtoIvaConvRec100 { get; set; }

    public decimal LlgDocMtoIvaLocalRecPro { get; set; }

    public decimal LlgDocMtoIvaConvRecPro { get; set; }

    public decimal LlgDocMtoIvaLocalNoRec { get; set; }

    public decimal LlgDocMtoIvaConvNoRec { get; set; }

    public decimal PPorcRetId { get; set; }

    public double PorcRetPorcentaje { get; set; }

    public decimal LlgDocMtoImpGravIva { get; set; }

    public decimal LlgDocMtoImpRetIva { get; set; }

    public decimal LlgCorrFolio { get; set; }
}
