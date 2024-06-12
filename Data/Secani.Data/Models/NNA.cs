﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Secani.Data.Models
{
    public class NNA : _BaseEntity
    {
        public int estadoId { get; set; }
        public int ResidenciaActualCategoriaId { get; set; }
        public int ResidenciaActualMunicipioId { get; set; }
        public string ResidenciaActualBarrio { get; set; }
        public int ResidenciaActualAreaId { get; set; }
        public string ResidenciaActualDireccion { get; set; }
        public string ResidenciaActualEstratoId { get; set; }
        public string ResidenciaActualTelefono { get; set; }
        public int ResidenciaOrigenCategoriaId { get; set; }
        public int ResidenciaOrigenMunicipioId { get; set; }
        public string ResidenciaOrigenBarrio { get; set; }
        public int ResidenciaOrigenAreaId { get; set; }
        public string ResidenciaOrigenDireccion { get; set; }
        public int ResidenciaOrigenEstratoId { get; set; }
        public string ResidenciaOrigenTelefono { get; set; }
        public DateTime FechaNotificacionSIVIGILA { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int TipoIdentificacionId { get; set; }
        public string NumeroIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad() => DateTime.Today.Year - FechaNacimiento.Year - (DateTime.Today.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);
        public int MunicipioNacimientoId { get; set; }
        public int SexoId { get; set; }
        public int TipoRegimenSSId { get; set; }
        public int EAPBId { get; set; }
        public int EPSId { get; set; }
        public int IPSId { get; set; }
        public int GrupoPoblacionId { get; set; }
        public int EtniaId { get; set; }
        public int EstadoIngresoEstrategiaId { get; set; }
        public DateTime FechaIngresoEstrategia { get; set; }
        public int OrigenReporteId { get; set; }
        public DateTime FechaConsultaOrigenReporte { get; set; }
        public int TipoCancerId { get; set; }
        public DateTime FechaInicioSintomas { get; set; }
        public DateTime FechaHospitalizacion { get; set; }
        public DateTime FechaDefuncion { get; set; }
        public string MotivoDefuncion { get; set; }
        public DateTime FechaInicioTratamiento { get; set; }
        public bool Recaida { get; set; }
        public int CantidadRecaidas { get; set; }
        public DateTime FechaUltimaRecaida { get; set; }
        public int TipoDiagnosticoId { get; set; }
        public string DiagnosticoId { get; set; }
        public DateTime FechaDiagnostico { get; set; }
        public int MotivoNoDiagnosticoId { get; set; }
        public string MotivoNoDiagnosticoOtro { get; set; }
        public DateTime FechaConsultaDiagnostico { get; set; }
        public int DepartamentoTratamientoId { get; set; }
        public bool IPSIdTratamiento { get; set; }
        public bool PropietarioResidenciaActual { get; set; }
        public string PropietarioResidenciaActualOtro { get; set; }
        public bool TrasladoTieneCapacidadEconomica { get; set; }
        public bool TrasladoEAPBSuministroApoyo { get; set; }
        public bool TrasladosServiciosdeApoyoOportunos { get; set; }
        public bool TrasladosServiciosdeApoyoCobertura { get; set; }
        public bool TrasladosHaSolicitadoApoyoFundacion { get; set; }
        public bool TrasladosNombreFundacion { get; set; }
        public bool TrasladosApoyoRecibidoxFundacion { get; set; }
        public bool DifAutorizaciondeMedicamentos { get; set; }
        public bool DifEntregaMedicamentosLAP { get; set; }
        public bool DifEntregaMedicamentosNoLAP { get; set; }
        public bool DifAsignaciondeCitas { get; set; }
        public bool DifHanCobradoCuotasoCopagos { get; set; }
        public bool DifAutorizacionProcedimientos { get; set; }
        public bool DifRemisionInstitucionesEspecializadas { get; set; }
        public bool DifMalaAtencionIPS { get; set; }
        public int DifMalaAtencionNombreIPSId { get; set; }
        public bool DifFallasenMIPRES { get; set; }
        public bool DifFallaConvenioEAPBeIPSTratante { get; set; }
        public int CategoriaAlertaId { get; set; }
        public int SubcategoriaAlertaId { get; set; }
        public bool TrasladosHaSidoTrasladadodeInstitucion { get; set; }
        public int TrasladosNumerodeTraslados { get; set; }
        public int TrasladosIPSId { get; set; }
        public bool TrasladosHaRecurridoAccionLegal { get; set; }
        public int TrasladosTipoAccionLegalId { get; set; }
        public bool TratamientoHaDejadodeAsistir { get; set; }
        public int TratamientoCuantoTiemposinAsistir { get; set; }
        public int TratamientoUnidadMedidaIdTiempoId { get; set; }
        public int TratamientoCausasInasistenciaId { get; set; }
        public string TratamientoCausasInasistenciaOtra { get; set; }
        public bool TratamientoEstudiaActualmente { get; set; }
        public bool TratamientoHaDejadodeAsistirColegio { get; set; }
        public int TratamientoTiempoInasistenciaColegio { get; set; }
        public int TratamientoTiempoInasistenciaUnidadMedidaId { get; set; }
        public bool TratamientoHaSidoInformadoClaramente { get; set; }
        public string TratamientoObservaciones { get; set; }
        public string CuidadorNombres { get; set; }
        public int CuidadorParentescoId { get; set; }
        public string CuidadorEmail { get; set; }
        public string CuidadorTelefono { get; set; }
        public string SeguimientoLoDesea { get; set; }
        public string SeguimientoMotivoNoLoDesea { get; set; }
    }

    public class NNAConfiguration : IEntityTypeConfiguration<NNA>
    {
        public void Configure(EntityTypeBuilder<NNA> builder)
        {

        }
    }
}
