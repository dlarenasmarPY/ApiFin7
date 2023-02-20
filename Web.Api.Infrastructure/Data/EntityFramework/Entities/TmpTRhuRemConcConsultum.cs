using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemConcConsultum
{
    public decimal TmpVarId { get; set; }

    public string CodOwner { get; set; } = null!;

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public decimal PCtoId { get; set; }

    public decimal? PRemAtrMid { get; set; }

    public string? TbMnombre { get; set; }

    public string? AtrMnombre { get; set; }

    public string VarCodigo { get; set; } = null!;

    public byte VarIndArreglo { get; set; }

    public short VarItemArreglo { get; set; }

    public double VarValor { get; set; }

    public string? VarString { get; set; }

    public DateTime? VarFecha { get; set; }

    public short? VarHora { get; set; }

    public decimal? PItmParId { get; set; }

    public decimal? VitValPar1 { get; set; }

    public decimal? VitValPar2 { get; set; }

    public decimal? VitValPar3 { get; set; }

    public decimal? VitValPar4 { get; set; }

    public decimal? VitValPar5 { get; set; }

    public decimal? VitValPar6 { get; set; }

    public decimal? VitValPar7 { get; set; }

    public decimal? VitValPar8 { get; set; }

    public decimal? VitValPar9 { get; set; }

    public decimal? VitValPar10 { get; set; }

    public DateTime? CnMfecVigencia { get; set; }

    public decimal PConcRemId { get; set; }
}
