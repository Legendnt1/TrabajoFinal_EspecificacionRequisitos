using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class AccesoYUsoDeVideoconferenciasEnTiempoRealStepDefinitions
    {
        [Given(@"que el usuario desea unirse a una videoconferencia activa")]
        public void GivenQueElUsuarioDeseaUnirseAUnaVideoconferenciaActiva()
        {
            throw new PendingStepException();
        }

        [When(@"navega a ""([^""]*)"" y selecciona una sala activa")]
        public void WhenNavegaAYSeleccionaUnaSalaActiva(string videoconferencias)
        {
            throw new PendingStepException();
        }

        [When(@"presiona el botón ""([^""]*)""")]
        public void WhenPresionaElBoton(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"la videoconferencia se carga y el usuario puede ver y escuchar a los otros participantes en tiempo real")]
        public void ThenLaVideoconferenciaSeCargaYElUsuarioPuedeVerYEscucharALosOtrosParticipantesEnTiempoReal()
        {
            throw new PendingStepException();
        }

        [Then(@"el usuario puede activar o desactivar su cámara y micrófono durante la sesión")]
        public void ThenElUsuarioPuedeActivarODesactivarSuCamaraYMicrofonoDuranteLaSesion()
        {
            throw new PendingStepException();
        }
    }
}
