using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ConfiguracionDeAuditoriaYLogsDeSeguridadStepDefinitions
    {
        [Given(@"que un usuario realiza acciones en la plataforma")]
        public void GivenQueUnUsuarioRealizaAccionesEnLaPlataforma()
        {
            throw new PendingStepException();
        }

        [When(@"se detecta una acción relevante \(inicio de sesión, cambio de perfil, etc\.\)")]
        public void WhenSeDetectaUnaAccionRelevanteInicioDeSesionCambioDePerfilEtc_()
        {
            throw new PendingStepException();
        }

        [Then(@"el sistema guarda los detalles en los logs de seguridad")]
        public void ThenElSistemaGuardaLosDetallesEnLosLogsDeSeguridad()
        {
            throw new PendingStepException();
        }

        [Then(@"el administrador puede acceder a ellos cuando lo requiera")]
        public void ThenElAdministradorPuedeAccederAEllosCuandoLoRequiera()
        {
            throw new PendingStepException();
        }

        [Given(@"que el sistema detecta una actividad que coincide con patrones sospechosos")]
        public void GivenQueElSistemaDetectaUnaActividadQueCoincideConPatronesSospechosos()
        {
            throw new PendingStepException();
        }

        [When(@"esta actividad se registra en los logs")]
        public void WhenEstaActividadSeRegistraEnLosLogs()
        {
            throw new PendingStepException();
        }

        [Then(@"se genera una notificación automática para el administrador")]
        public void ThenSeGeneraUnaNotificacionAutomaticaParaElAdministrador()
        {
            throw new PendingStepException();
        }

        [Then(@"se marca el registro como de ""([^""]*)"" para su revisión inmediata")]
        public void ThenSeMarcaElRegistroComoDeParaSuRevisionInmediata(string p0)
        {
            throw new PendingStepException();
        }
    }
}
