using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ConsistenciaEnLasNotificacionesEntreDispositivosStepDefinitions
    {
        [Given(@"que el usuario está registrado en la plataforma")]
        public void GivenQueElUsuarioEstaRegistradoEnLaPlataforma()
        {
            throw new PendingStepException();
        }

        [When(@"se envía una notificación de un nuevo evento o mensaje")]
        public void WhenSeEnviaUnaNotificacionDeUnNuevoEventoOMensaje()
        {
            throw new PendingStepException();
        }

        [Then(@"la notificación debe aparecer en todos los dispositivos en los que el usuario haya iniciado sesión")]
        public void ThenLaNotificacionDebeAparecerEnTodosLosDispositivosEnLosQueElUsuarioHayaIniciadoSesion()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario ha leído una notificación en su teléfono")]
        public void GivenQueElUsuarioHaLeidoUnaNotificacionEnSuTelefono()
        {
            throw new PendingStepException();
        }

        [When(@"accede a la plataforma desde su computadora")]
        public void WhenAccedeALaPlataformaDesdeSuComputadora()
        {
            throw new PendingStepException();
        }

        [Then(@"la notificación debe aparecer como leída en ambos dispositivos")]
        public void ThenLaNotificacionDebeAparecerComoLeidaEnAmbosDispositivos()
        {
            throw new PendingStepException();
        }
    }
}
