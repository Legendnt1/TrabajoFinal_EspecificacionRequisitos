using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class IniciarYFinalizarUnaVideoconferenciaStepDefinitions
    {
        [Given(@"que el usuario desea crear una videoconferencia")]
        public void GivenQueElUsuarioDeseaCrearUnaVideoconferencia()
        {
            throw new PendingStepException();
        }

        [When(@"navega a ""([^""]*)"" y presiona el botón ""([^""]*)""")]
        public void WhenNavegaAYPresionaElBoton(string videoconferencias, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"completa los detalles como nombre de la sala y participantes invitados")]
        public void WhenCompletaLosDetallesComoNombreDeLaSalaYParticipantesInvitados()
        {
            throw new PendingStepException();
        }

        [Then(@"la videoconferencia se inicia y los otros usuarios pueden unirse")]
        public void ThenLaVideoconferenciaSeIniciaYLosOtrosUsuariosPuedenUnirse()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario es el anfitrión de una videoconferencia activa")]
        public void GivenQueElUsuarioEsElAnfitrionDeUnaVideoconferenciaActiva()
        {
            throw new PendingStepException();
        }

        [Then(@"todos los participantes son desconectados y la sesión de videoconferencia se cierra")]
        public void ThenTodosLosParticipantesSonDesconectadosYLaSesionDeVideoconferenciaSeCierra()
        {
            throw new PendingStepException();
        }
    }
}
