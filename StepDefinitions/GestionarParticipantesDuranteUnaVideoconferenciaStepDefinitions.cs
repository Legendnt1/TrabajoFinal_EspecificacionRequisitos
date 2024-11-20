using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class GestionarParticipantesDuranteUnaVideoconferenciaStepDefinitions
    {
        [Given(@"que el anfitrión está gestionando una videoconferencia")]
        public void GivenQueElAnfitrionEstaGestionandoUnaVideoconferencia()
        {
            throw new PendingStepException();
        }

        [When(@"selecciona un participante y presiona ""([^""]*)""")]
        public void WhenSeleccionaUnParticipanteYPresiona(string silenciar)
        {
            throw new PendingStepException();
        }

        [Then(@"el micrófono del participante se desactiva")]
        public void ThenElMicrofonoDelParticipanteSeDesactiva()
        {
            throw new PendingStepException();
        }

        [Then(@"el anfitrión recibe una confirmación de que el participante ha sido silenciado")]
        public void ThenElAnfitrionRecibeUnaConfirmacionDeQueElParticipanteHaSidoSilenciado()
        {
            throw new PendingStepException();
        }

        [Given(@"que el anfitrión necesita expulsar a un participante de la videoconferencia")]
        public void GivenQueElAnfitrionNecesitaExpulsarAUnParticipanteDeLaVideoconferencia()
        {
            throw new PendingStepException();
        }

        [When(@"selecciona un participante y presiona ""([^""]*)""")]
        public void WhenSeleccionaUnParticipanteYPresiona(string expulsar)
        {
            throw new PendingStepException();
        }

        [Then(@"el participante es desconectado de la videoconferencia")]
        public void ThenElParticipanteEsDesconectadoDeLaVideoconferencia()
        {
            throw new PendingStepException();
        }

        [Then(@"no puede volver a unirse a la misma sesión")]
        public void ThenNoPuedeVolverAUnirseALaMismaSesion()
        {
            throw new PendingStepException();
        }
    }
}
