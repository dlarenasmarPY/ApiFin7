using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpInterfazAux
{
    public decimal InterfazAuxId { get; set; }

    public string InterfazTmpOwner { get; set; } = null!;

    public string InterfazBitArchivo { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short ProNegocioCod { get; set; }

    public string IdUsuario { get; set; } = null!;

    public decimal PTipoOpeId { get; set; }

    public DateTime FechaRequerida { get; set; }

    public int BodegaCod { get; set; }

    public byte PedidoParcialidad { get; set; }

    public byte PedidoTipoRecepcion { get; set; }

    public int CconsumoCod { get; set; }

    public int BodegaDestinoCod { get; set; }

    public string GlosaLogtCab { get; set; } = null!;

    public string ProductoCod { get; set; } = null!;

    public double Cantidad { get; set; }

    public string UnidadMedCod { get; set; } = null!;

    public string GlosaLogtDet { get; set; } = null!;

    public byte InterfazAuxError { get; set; }

    public DateTime FechaProceso { get; set; }

    public int CreCodigo { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal IdDocumento { get; set; }
}
