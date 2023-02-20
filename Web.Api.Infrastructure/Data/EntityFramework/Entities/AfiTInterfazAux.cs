using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTInterfazAux
{
    public decimal IntIntId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public string IntBitArchivo { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public string AfiDescripcion { get; set; } = null!;

    public short AfiSubGrpCod { get; set; }

    public decimal AfiOpeCod { get; set; }

    public int AfiCantidad { get; set; }

    public string AfiCodAnterior { get; set; } = null!;

    public decimal AfiUbiFisicaCod { get; set; }

    public string EntRut { get; set; } = null!;

    public short AfiUnidadCod { get; set; }

    public string AfiCodBarraBien { get; set; } = null!;

    public DateTime AfiFechaIngreso { get; set; }

    public string ProductoCod { get; set; } = null!;

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public int CdiCodigo { get; set; }

    public decimal PPartidaId { get; set; }

    public byte AfiIndSecuencia { get; set; }

    public int CreCodigo { get; set; }

    public string EntRut2 { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public decimal PMonedaId { get; set; }

    public int AfiCantidadCompra { get; set; }

    public double AfiValorCompra { get; set; }

    public string AfiNacImp { get; set; } = null!;

    public DateTime AfiFechaAdq { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public short TdoId { get; set; }

    public string AfiMarca { get; set; } = null!;

    public string AfiModelo { get; set; } = null!;

    public string AfiCodSerie { get; set; } = null!;

    public string AfiCodAgrup { get; set; } = null!;

    public byte AfiTipoCalculoCod { get; set; }

    public short AfiEjercicioInc { get; set; }

    public byte AfiPerMesInc { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public short AfiEjercicioInDep { get; set; }

    public byte AfiPerMesInDep { get; set; }

    public double AfiValorAdq { get; set; }

    public double AfiValorActualizado { get; set; }

    public double AfiValorLibro { get; set; }

    public double AfiCorrMonVlejeIng { get; set; }

    public double AfiCorrMonAcumIng { get; set; }

    public double AfiValorResidual { get; set; }

    public double AfiDepAcumEjeAntIng { get; set; }

    public double AfiCmdepAcumEjeIng { get; set; }

    public byte AfiUsaDepHoras { get; set; }

    public int AfiVidaOriginal { get; set; }

    public int AfiVidaEjer { get; set; }

    public int AfiSaldoVida { get; set; }

    public short AfiMesesAdep { get; set; }

    public double AfiDepAcumEjeIng { get; set; }

    public double AfiValorNetoIng { get; set; }

    public double AfiTasacionInicial { get; set; }

    public byte IntError { get; set; }

    public double AfiPorcentajeResp { get; set; }

    public byte AfiTipoSegCod { get; set; }

    public string AfiEspTecnica { get; set; } = null!;

    public string EntRutEcua { get; set; } = null!;

    public string EntRutEcua2 { get; set; } = null!;
}
