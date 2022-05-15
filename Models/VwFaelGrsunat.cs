using System;
using System.Collections.Generic;

#nullable disable

namespace PLANTILLA_API_ODATA.Models
{
    public partial class VwFaelGrsunat
    {
        public string CodigoEmpresa { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public DateTime FechDocu { get; set; }
        public string ConfRazonSocial { get; set; }
        public string NombComercial { get; set; }
        public string UbigeoPartida { get; set; }
        public string ConfDireccion { get; set; }
        public string Urbanizacion { get; set; }
        public string ProvinciaPartida { get; set; }
        public string DepartamentoPartida { get; set; }
        public string DistritoPartida { get; set; }
        public string UbigeoLlegada { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public string Distrito { get; set; }
        public string LugarPartida { get; set; }
        public string LugarEntrega { get; set; }
        public string Pais { get; set; }
        public string ConfRuc { get; set; }
        public string TipoDocuEmpr { get; set; }
        public string TipoDocu { get; set; }
        public string NumeDocu { get; set; }
        public string ClienteRuc { get; set; }
        public string TipoDocuClie { get; set; }
        public string ClienteNombre { get; set; }
        public string CdgMg { get; set; }
        public string NomMg { get; set; }
        public string UnidadPeso { get; set; }
        public int PesoTotal { get; set; }
        public string CdgMt { get; set; }
        public string CdgTdTran { get; set; }
        public string RucTransportista { get; set; }
        public string NomTransportista { get; set; }
        public string CdgTdChofer { get; set; }
        public string RucChofer { get; set; }
        public string LicenciaChofer { get; set; }
        public string CodigoProducto { get; set; }
        public string ExistenciaNombre { get; set; }
        public decimal? Cantidad { get; set; }
        public string Unidad { get; set; }
        public string NomUnidad { get; set; }
        public int Secuencia { get; set; }
        public decimal IdGuia { get; set; }
        public string VersionUbl { get; set; }
        public string VersionEstructura { get; set; }
        public string HoraEmision { get; set; }
        public string Series { get; set; }
        public string ValorResumen { get; set; }
        public string SwtFe { get; set; }
        public decimal IdDocumento { get; set; }
        public string CentroCosto { get; set; }
    }
}
