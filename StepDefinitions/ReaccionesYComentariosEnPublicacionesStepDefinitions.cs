using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ReaccionesYComentariosEnPublicacionesStepDefinitions
    {
        [Given(@"que el usuario desea reaccionar o comentar en una publicación")]
        public void GivenQueElUsuarioDeseaReaccionarOComentarEnUnaPublicacion()
        {
            throw new PendingStepException();
        }

        [When(@"selecciona una reacción o ingresa un comentario y hace clic en ""([^""]*)""")]
        public void WhenSeleccionaUnaReaccionOIngresaUnComentarioYHaceClicEn(string enviar)
        {
            throw new PendingStepException();
        }

        [Then(@"se muestra la reacción o el comentario en la publicación seleccionada")]
        public void ThenSeMuestraLaReaccionOElComentarioEnLaPublicacionSeleccionada()
        {
            throw new PendingStepException();
        }

        [Given(@"que la conexión es inestable")]
        public void GivenQueLaConexionEsInestable()
        {
            throw new PendingStepException();
        }

        [Then(@"se muestra el mensaje ""([^""]*)""")]
        public void ThenSeMuestraElMensaje(string p0)
        {
            throw new PendingStepException();
        }
    }
}
