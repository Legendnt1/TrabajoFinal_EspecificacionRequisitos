using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EnvioDeSolicitudesDeAmistadStepDefinitions
    {
        [Given(@"que el usuario desea agregar a otra persona como amigo")]
        public void GivenQueElUsuarioDeseaAgregarAOtraPersonaComoAmigo()
        {
            throw new PendingStepException();
        }

        [When(@"selecciona ""([^""]*)"" en el perfil del otro usuario")]
        public void WhenSeleccionaEnElPerfilDelOtroUsuario(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"se muestra el mensaje ""([^""]*)""")]
        public void ThenSeMuestraElMensaje(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"que ya existe una solicitud pendiente o el usuario está bloqueado")]
        public void GivenQueYaExisteUnaSolicitudPendienteOElUsuarioEstaBloqueado()
        {
            throw new PendingStepException();
        }
    }
}
