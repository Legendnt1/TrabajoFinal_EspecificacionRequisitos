using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class GrabarUnaVideoconferenciaStepDefinitions
    {
        [Then(@"la videoconferencia comienza a grabarse")]
        public void ThenLaVideoconferenciaComienzaAGrabarse()
        {
            throw new PendingStepException();
        }

        [Then(@"aparece una notificación visible para todos los participantes indicando que la sesión está siendo grabada")]
        public void ThenApareceUnaNotificacionVisibleParaTodosLosParticipantesIndicandoQueLaSesionEstaSiendoGrabada()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario está grabando una videoconferencia activa")]
        public void GivenQueElUsuarioEstaGrabandoUnaVideoconferenciaActiva()
        {
            throw new PendingStepException();
        }

        [Then(@"la grabación se detiene")]
        public void ThenLaGrabacionSeDetiene()
        {
            throw new PendingStepException();
        }

        [Then(@"se guarda en el perfil del anfitrión")]
        public void ThenSeGuardaEnElPerfilDelAnfitrion()
        {
            throw new PendingStepException();
        }

        [Then(@"se genera un enlace para descargar o compartir el video")]
        public void ThenSeGeneraUnEnlaceParaDescargarOCompartirElVideo()
        {
            throw new PendingStepException();
        }
    }
}
