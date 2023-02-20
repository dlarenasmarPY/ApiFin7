using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VenTDoctoLegalCar
{
    public decimal DoctoLegalCarId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public int Linea { get; set; }

    public short TdoId { get; set; }

    public int DlcFolioDocto { get; set; }

    public decimal PTipoOpeId { get; set; }

    public int PVenId { get; set; }

    public DateTime DlcFecDocto { get; set; }

    public DateTime DlcFecVecto { get; set; }

    public DateTime DlcFecDespacho { get; set; }

    public string CliRut { get; set; } = null!;

    public short CliSucNumero { get; set; }

    public short CdpId { get; set; }

    public double CdpPorcCargo { get; set; }

    public double CdpPorcDescto { get; set; }

    public double DvcDescto1 { get; set; }

    public double DvcDescto2 { get; set; }

    public double DvcDescto3 { get; set; }

    public double DvcDescto4 { get; set; }

    public int CreCodigoCab { get; set; }

    public byte CfgMoneda { get; set; }

    public double CfgPorcIva { get; set; }

    public short DteId { get; set; }

    public decimal PBodegaId { get; set; }

    public byte DlcEstado { get; set; }

    public byte DlcEstadoDte { get; set; }
}
