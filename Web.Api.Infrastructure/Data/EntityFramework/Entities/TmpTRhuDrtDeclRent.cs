using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuDrtDeclRent
{
    public decimal DrtTmpId { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal DrtColDeclItmId { get; set; }

    public decimal DrtConcRemId { get; set; }

    public short DrtPerIdDev { get; set; }

    public short DrtPerIdPag { get; set; }

    public double DrtValor { get; set; }

    public double DrtValorAct { get; set; }

    public string DrtTblOrigen { get; set; } = null!;

    public decimal DrtIdRefOrigen { get; set; }

    public decimal PCtoId { get; set; }

    public byte PerMes { get; set; }

    public string DrtTipoJornada { get; set; } = null!;
}
