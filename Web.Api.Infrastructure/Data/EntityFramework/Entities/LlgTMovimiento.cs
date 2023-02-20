using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTMovimiento
{
    public decimal MovLlgId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public byte SisCodOri { get; set; }

    public decimal PCabllgId { get; set; }

    public int CabOpeLinea { get; set; }

    public short ClcId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public short TdoId { get; set; }

    public string LlgDocNumDoc { get; set; } = null!;

    public short LlgDocNumCuota { get; set; }

    public DateTime LlgDocFechaVenc { get; set; }

    public DateTime LlgDocFecProyectada { get; set; }

    public decimal LlgDocDetMtoImpuDebe { get; set; }

    public decimal LlgDocDetMtoImpuHaber { get; set; }

    public decimal LlgDocDetMtoLocalDebe { get; set; }

    public decimal LlgDocDetMtoLocalHaber { get; set; }

    public double LlgDocMontoConvDebe { get; set; }

    public double LlgDocMontoConvHaber { get; set; }

    public string LlgDocGlosa { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PLineaProdId { get; set; }

    public byte NivId { get; set; }

    public decimal PPartidaId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PDetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public string LlgDocOwner { get; set; } = null!;

    public decimal PEmpIdDestino { get; set; }

    public short DivCodigoDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public decimal PMovCceId { get; set; }

    public string MovLlgDocRef { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PDetReferenciaId { get; set; }
}
