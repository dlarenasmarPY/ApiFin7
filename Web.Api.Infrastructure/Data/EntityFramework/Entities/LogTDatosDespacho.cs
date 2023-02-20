using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTDatosDespacho
{
    public decimal DatosDespId { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public string DatosDespDir { get; set; } = null!;

    public byte RegCodigo { get; set; }

    public int CmuCodigo { get; set; }

    public decimal PRutaDespId { get; set; }

    public string DatosDespAtencion { get; set; } = null!;

    public string DatosDespHorario { get; set; } = null!;

    public string GlosaExis { get; set; } = null!;

    public short TdoId { get; set; }

    public int DlcFolioDocto { get; set; }

    public decimal PEntDirId { get; set; }
}
