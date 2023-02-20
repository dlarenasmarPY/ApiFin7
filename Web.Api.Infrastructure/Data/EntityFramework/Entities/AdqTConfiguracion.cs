using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public byte IndModificaPrecio { get; set; }

    public byte IndModificaValorUni { get; set; }

    public int IndMinimoOfertas { get; set; }

    public double IndPorcHolgura { get; set; }

    public byte IndTipoAprobacion { get; set; }

    public byte IndCorrTipoOpe { get; set; }

    public short TdoIdOc { get; set; }

    public short TdoIdOp { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte IndCostoProductoFlete { get; set; }

    public byte IndPrecio { get; set; }

    public byte IndAcumulaItems { get; set; }

    public byte IndTipoFormatoOc { get; set; }

    public decimal PTipoOpeConvenio { get; set; }

    public decimal PProdClasId { get; set; }

    public byte IndApruebaConIva { get; set; }

    public byte IndPptoCompra { get; set; }

    public byte IndPptoPeriodo { get; set; }

    public byte IndTipoDescInfCot { get; set; }

    public byte IndTipoFlujo { get; set; }

    public byte IndHeredaGlosaItem { get; set; }

    public byte IndAsociaDocRecep { get; set; }

    public short CantDiasAtraso { get; set; }

    public byte AgrupaPorGlosa { get; set; }

    public byte IndRecepBodegas { get; set; }

    public byte ConsideraIvaRecepcion { get; set; }

    public byte? IndGlosasEspHo { get; set; }

    public byte IndCalcPrecioReceta { get; set; }

    public byte IndFiltraVisadores { get; set; }

    public byte ValidaProcedencia { get; set; }

    public virtual GlbTEmpresa PEmp { get; set; } = null!;
}
