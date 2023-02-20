using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpDevolTrasp
{
    public string CodOwner { get; set; } = null!;

    public decimal PProductoId { get; set; }

    public string UnidadMedCod { get; set; } = null!;

    public decimal Saldo { get; set; }

    public double CantEstd { get; set; }

    public decimal Porcentaje { get; set; }

    public double CantAprob { get; set; }

    public double Consumo { get; set; }

    public double PDevolucionCabId { get; set; }

    public double EstConsPromMensual { get; set; }

    public string Lote { get; set; } = null!;

    public decimal POpeLogtCabId { get; set; }

    public byte Indicador { get; set; }

    public decimal POpcabId { get; set; }

    public short Correlativo { get; set; }
}
