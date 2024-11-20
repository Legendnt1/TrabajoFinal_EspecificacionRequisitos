using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PriorizacionDeEventosCercanosStepDefinitions
    {
        [Given(@"que el usuario desea tener en prioridad los eventos más cercanos")]
        public void GivenQueElUsuarioDeseaTenerEnPrioridadLosEventosMasCercanos()
        {
            throw new PendingStepException();
        }

        [When(@"vea el listado de eventos")]
        public void WhenVeaElListadoDeEventos()
        {
            throw new PendingStepException();
        }

        [Then(@"habrá una opción de ordenamiento donde se le enseñará mediante la distancia los eventos")]
        public void ThenHabraUnaOpcionDeOrdenamientoDondeSeLeEnsenaraMedianteLaDistanciaLosEventos()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario no ha activado la ubicación exacta para la app")]
        public void GivenQueElUsuarioNoHaActivadoLaUbicacionExactaParaLaApp()
        {
            throw new PendingStepException();
        }

        [Then(@"no se puede ordenar por distancia los eventos")]
        public void ThenNoSePuedeOrdenarPorDistanciaLosEventos()
        {
            throw new PendingStepException();
        }
    }
}
