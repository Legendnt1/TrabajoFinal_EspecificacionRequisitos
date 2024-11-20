using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EnviarMensajesDeTextoDuranteUnaVideoconferenciaStepDefinitions
    {
        [Given(@"que el usuario está participando en una videoconferencia activa")]
        public void GivenQueElUsuarioEstaParticipandoEnUnaVideoconferenciaActiva()
        {
            throw new PendingStepException();
        }

        [When(@"presiona el botón ""([^""]*)"" en la interfaz de la videoconferencia")]
        public void WhenPresionaElBotonEnLaInterfazDeLaVideoconferencia(string chat)
        {
            throw new PendingStepException();
        }

        [When(@"escribe un mensaje en el campo de texto")]
        public void WhenEscribeUnMensajeEnElCampoDeTexto()
        {
            throw new PendingStepException();
        }

        [Then(@"el mensaje aparece en el chat visible para todos los participantes sin interrumpir la videollamada")]
        public void ThenElMensajeApareceEnElChatVisibleParaTodosLosParticipantesSinInterrumpirLaVideollamada()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario está participando en una videoconferencia")]
        public void GivenQueElUsuarioEstaParticipandoEnUnaVideoconferencia()
        {
            throw new PendingStepException();
        }

        [When(@"otro participante envía un mensaje de texto en el chat")]
        public void WhenOtroParticipanteEnviaUnMensajeDeTextoEnElChat()
        {
            throw new PendingStepException();
        }

        [Then(@"el usuario ve una notificación visual en la pantalla sin que se interrumpa el flujo de la videollamada")]
        public void ThenElUsuarioVeUnaNotificacionVisualEnLaPantallaSinQueSeInterrumpaElFlujoDeLaVideollamada()
        {
            throw new PendingStepException();
        }
    }
}
