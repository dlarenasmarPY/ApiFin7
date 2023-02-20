using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTListaPrecioCab
{
    public decimal ListaPreCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short CodigoLista { get; set; }

    public string ListaPreDes { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public decimal PEntId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCondPagoId { get; set; }

    public short PlazoNormalPago { get; set; }

    public short PlazoPrePago { get; set; }

    public double DesctoPorcPrepago { get; set; }

    public decimal PClausulaId { get; set; }

    public double ClausulaPorcFob { get; set; }

    public double ClausulaPorcCif { get; set; }

    public double ClausulaPorcBodega { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string LogOwner { get; set; } = null!;

    public byte LprTipoPrecioMinimo { get; set; }

    public double LprPorcPrecioMinimo { get; set; }

    public decimal PDescuentoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string ReferenciaProv { get; set; } = null!;

    public short DivCodigo { get; set; }
}
