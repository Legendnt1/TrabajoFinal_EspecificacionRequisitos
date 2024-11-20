using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class NavegacionConTecladoMejoradaStepDefinitions
    {
        [Given(@"que el usuario está en cualquier página de la plataforma")]
        public void GivenQueElUsuarioEstaEnCualquierPaginaDeLaPlataforma()
        {
            throw new PendingStepException();
        }

        [When(@"utiliza las teclas de navegación del teclado")]
        public void WhenUtilizaLasTeclasDeNavegacionDelTeclado()
        {
            throw new PendingStepException();
        }

        [When(@"presiona ""([^""]*)"" para moverse entre elementos interactivos")]
        public void WhenPresionaParaMoverseEntreElementosInteractivos(string tab)
        {
            throw new PendingStepException();
        }

        [Then(@"todos los elementos de la interfaz deben poder seleccionarse secuencialmente")]
        public void ThenTodosLosElementosDeLaInterfazDebenPoderSeleccionarseSecuencialmente()
        {
            throw new PendingStepException();
        }

        [Given(@"que el usuario está en la página principal")]
        public void GivenQueElUsuarioEstaEnLaPaginaPrincipal()
        {
            throw new PendingStepException();
        }

        [When(@"presiona ""([^""]*)"" en combinación con la tecla de flechas")]
        public void WhenPresionaEnCombinacionConLaTeclaDeFlechas(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"debe poder saltar a secciones principales \(menú, contenido principal, pie de página\) sin dificultad")]
        public void ThenDebePoderSaltarASeccionesPrincipalesMenuContenidoPrincipalPieDePaginaSinDificultad()
        {
            throw new PendingStepException();
        }
    }
}
