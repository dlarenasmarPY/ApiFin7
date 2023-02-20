using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ObrTConfiguracion
{
    public int PproyectoId { get; set; }

    public short TipoProyecto { get; set; }

    public short UniCodigo { get; set; }

    public int CodigoBodega { get; set; }

    public int LugarEntrega { get; set; }

    public short TipoDoctoObras { get; set; }

    public int MovConsumo { get; set; }

    public short TipoDoctoDespacho { get; set; }

    public short TipoDoctoDevolucion { get; set; }

    public byte IndConfDec { get; set; }

    public byte NroDecCtdad { get; set; }

    public short TipoDoctoTraspaso { get; set; }

    public int MovimientoTraspaso { get; set; }

    public short TipoDoctoRecepcion { get; set; }

    public int MovimientoRecepcion { get; set; }

    public short TesTdoId { get; set; }

    public byte NivelCtaGtoObr { get; set; }

    public short PeriodoAvance { get; set; }

    public byte CalificaMo { get; set; }

    public int FhaberPesos { get; set; }

    public int FhaberDlic { get; set; }

    public int FhaberDina { get; set; }

    public byte ObrConfCostoUnitario { get; set; }

    public int PartidaDist { get; set; }

    public byte TipoDespachoPartida { get; set; }

    public short CodDespachoAgrupaPartida { get; set; }

    public int CodDespachoPartida { get; set; }

    public byte TipoDoctoCompra { get; set; }

    public int LineaProducto { get; set; }

    public int ConceptoImp { get; set; }

    public decimal Iva { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte NroDecCtdadPartidas { get; set; }

    public int MovimientoDespacho { get; set; }

    public short HorasTurnoA { get; set; }

    public short HorasTurnoB { get; set; }

    public short HorasTurnoC { get; set; }

    public string UsrComprador { get; set; } = null!;

    public byte IndFacUti { get; set; }

    public byte DecRecPu { get; set; }

    public byte DecParVu { get; set; }

    public byte DecParCu { get; set; }

    public byte DecRecPt { get; set; }

    public byte DecParVt { get; set; }

    public byte DecParCt { get; set; }

    public byte IndDistHh { get; set; }

    public byte IndUsaSolicitante { get; set; }

    public int NroProyectoEspecial { get; set; }
}
