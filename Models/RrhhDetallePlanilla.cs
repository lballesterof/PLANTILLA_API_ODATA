using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class RrhhDetallePlanilla
    {
        public string CdgParam { get; set; }
        public decimal IdPersona { get; set; }
        public string CdgPlanilla { get; set; }
        public string Ano { get; set; }
        public int Mes { get; set; }
        public int Semana { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Importe { get; set; }
        public decimal Secuencia { get; set; }
        public string Ida { get; set; }
        public string Nrnr { get; set; }
        public string AfectoEssalud { get; set; }
        public string AfectoEssaludSctr { get; set; }
        public string AfectoSenati { get; set; }
        public string AfectoSistemaPension { get; set; }
        public string AfectoSistemaPrivadoPension { get; set; }
        public string AfectoQuintaCategoria { get; set; }
        public string AfectoGratificacion { get; set; }
        public string AfectoCts { get; set; }
        public string AfectoVacacion { get; set; }
        public string AfectoUtil { get; set; }
        public string AfectoLiquidacion { get; set; }
        public string TipoAsistencia { get; set; }
        public string Asistencia { get; set; }
        public string SwtPla { get; set; }
        public string NombreParam { get; set; }
        public string RefeParam { get; set; }
        public string Unidad { get; set; }
        public string AfectoOnpSctr { get; set; }
        public string AfectoConafovicer { get; set; }
        public decimal? AnoRef1 { get; set; }
        public decimal? MesRef1 { get; set; }
        public decimal? SemanaRef1 { get; set; }
        public string CdgProy { get; set; }
    }
}
